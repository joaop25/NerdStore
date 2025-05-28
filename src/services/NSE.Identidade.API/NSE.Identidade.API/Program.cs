using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NSE.Identidade.API.Data;
using NSE.Identidade.API.Extensions;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();




// Configuração do middleware para o JWT Bearer
var appSettingSection = builder.Configuration.GetSection("AppSettings");
builder.Services.Configure<AppSettings>(appSettingSection);

var appSettings = appSettingSection.Get<AppSettings>();
var key = Encoding.ASCII.GetBytes(appSettings.Secret);


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(bearerOptions =>
    {
       bearerOptions.RequireHttpsMetadata = true;
        bearerOptions.SaveToken = true;
        bearerOptions.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            //Valido somente dentro das APIs que eu quiser
            ValidateIssuer = true,
            //Audience (quem pode usar esse token - APIs) Quais dominios podem consumir o token
            ValidateAudience = true,
            //Valida o dominio que está consumindo o token 
            ValidAudience = appSettings.ValidoEm,
            ValidIssuer = appSettings.Emissor
        };
}); ;

//FIM Configuração do middleware para o JWT Bearer

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "NerdStore Enterprise Identity API",
        Description = "Este API faz parte do cusro ASP.NET Core Enterprise Application",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact() { Name = "João Pedro Fernandes", Email = "joaopfernandes.m@gmail.com"},
        License = new Microsoft.OpenApi.Models.OpenApiLicense() { Name = "MIT", Url = new Uri("https://opensource.org/license/mit/") },
        Version = "v1" 
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c=>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();


app.Run();
