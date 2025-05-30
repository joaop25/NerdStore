﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using NSE.Identidade.API.Extensions;
using NSE.Identidade.API.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NSE.Identidade.API.Controllers
{
    [ApiController]
    [Route("api/identidade")]
    public class AuthController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signManager;
        private readonly AppSettings _appSettings;

        public AuthController(SignInManager<IdentityUser> signManager, UserManager<IdentityUser> userManager, 
                                            IOptions<AppSettings> appSettings)
        {
            _signManager = signManager ?? throw new ArgumentNullException(nameof(signManager));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _appSettings = appSettings?.Value ?? throw new ArgumentNullException(nameof(appSettings));
        }

        [HttpPost("nova-conta")]
        public async Task<ActionResult> Registrar(UsuarioRegistro usuarioRegistro)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var user = new IdentityUser
            {
                UserName = usuarioRegistro.Email,
                Email = usuarioRegistro.Email,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, usuarioRegistro.Senha);
            if (result.Succeeded)
            {
                await _signManager.SignInAsync(user, isPersistent: false);
                return Ok(await GerarJwt(usuarioRegistro.Email));
            }

            return BadRequest();
        }


        [HttpPost("autenticar")]
        public async Task<ActionResult> Login(UsuarioLogin usuarioLogin)
        {
            if (!ModelState.IsValid) return BadRequest();

            var result = await _signManager.PasswordSignInAsync(usuarioLogin.Email, usuarioLogin.Senha, isPersistent: false, lockoutOnFailure: true);
            if (result.Succeeded)
            {
                return Ok(await GerarJwt(usuarioLogin.Email));
            }
            if (result.IsLockedOut)
            {
                return Forbid();
            }
            return Unauthorized();
        }

        private async Task<UsuarioRespostaLogin> GerarJwt(string email)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(email);
                var claims = await _userManager.GetClaimsAsync(user);
                var userRoles = await _userManager.GetRolesAsync(user);

                claims.Add(new Claim(JwtRegisteredClaimNames.Sub, user.Id));
                claims.Add(new Claim(JwtRegisteredClaimNames.Email, user.Email));
                claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
                claims.Add(new Claim(JwtRegisteredClaimNames.Nbf, ToUnixEpochDate(DateTime.UtcNow).ToString()));
                claims.Add(new Claim(JwtRegisteredClaimNames.Iat, ToUnixEpochDate(DateTime.UtcNow).ToString(),
                    ClaimValueTypes.Integer64));

                foreach (var role in userRoles)
                {
                    claims.Add(new Claim("role", role));
                }

                var identityClaims = new ClaimsIdentity();
                identityClaims.AddClaims(claims);

                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_appSettings.Secret);

                var token = tokenHandler.CreateToken(new SecurityTokenDescriptor
                {
                    Issuer = _appSettings.Emissor,
                    Audience = _appSettings.ValidoEm,
                    Subject = identityClaims,
                    //Formato da data em UTC
                    Expires = DateTime.UtcNow.AddHours(_appSettings.ExpiracaoHoras),
                    //Criptografia do token - HmacSha256Signature
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                });

                var encodedToken = tokenHandler.WriteToken(token);

                var response = new UsuarioRespostaLogin
                {
                    AccessToken = encodedToken,
                    ExpiresIn = TimeSpan.FromHours(_appSettings.ExpiracaoHoras).TotalSeconds,
                    UsuarioToken = new UsuarioToken
                    {
                        Id = user.Id,
                        Email = user.Email,
                        Claims = claims.Select(c => new UsuarioClaim { Type = c.Type, Value = c.Value })
                    }
                };

                return response;
            }
            catch(Exception ex)
            {
                // Log the exception (ex) as needed
                throw;
            }
        }

        private static long ToUnixEpochDate(DateTime date)
            => (long)Math.Round((date.ToUniversalTime() - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero))
                .TotalSeconds);

    }
}