using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NSE.Identidade.API.Models;

namespace NSE.Identidade.API.Controllers
{
    [ApiController]
    [Route("api/identidade")]
    public class AuthController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signManager;

        public AuthController(SignInManager<IdentityUser> signManager, UserManager<IdentityUser> userManager)
        {
            _signManager = signManager ?? throw new ArgumentNullException(nameof(signManager));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
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
                return Ok();
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
                return Ok();
            }
            if (result.IsLockedOut)
            {
                return Forbid();
            }
            return Unauthorized();
        }
    }
}
