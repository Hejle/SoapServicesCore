using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Server.Kestrel.Https;
using Microsoft.IdentityModel.Xml;
using RestApiCertificateTest;
using SoapServicesCore.Authentication;
using SoapServicesCore.Interfaces;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.AddConsole();
builder.Services.Configure<KestrelServerOptions>(kestrelServerOptions =>
{
    kestrelServerOptions.ConfigureHttpsDefaults(httpsConnectionAdapterOptions =>
    {
        httpsConnectionAdapterOptions.ClientCertificateMode = ClientCertificateMode.RequireCertificate;
        httpsConnectionAdapterOptions.AllowAnyClientCertificate();
    });
});
builder.Services.AddScoped<ICertificateValidationService, X509CertificateValidationService>();

builder.Services.AddAuthentication(CertificateAuthenticationDefaults.AuthenticationScheme)
    .AddCertificate(ValidateCertificateHandlerMethod())
    .AddCertificateCache(options =>
    {
        options.CacheSize = 1024;
        options.CacheEntryExpiration = TimeSpan.FromMinutes(2);
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("HasAccesPolicy", policy =>
        policy.RequireClaim("Access", "HasAccess")
        .AddAuthenticationSchemes(CertificateAuthenticationDefaults.AuthenticationScheme));
});
var app = builder.Build();
app.UseAuthentication();
app.UseAuthentication();

app.MapGet("/", (ClaimsPrincipal user) => user.Claims.Select(x => new {x.Type, x.Value}));

app.MapGet("/SecureService", () =>
{
    //var claims = context.User.Claims;
    //if (claims.FirstOrDefault(x => x.Type == "Access" && x.Value == "HasAccess") == null)
    //{
    //    context.Response.StatusCode = 403;
    //    return "";
    //}
    return "Hello from secure service";
}).RequireAuthorization("HasAccesPolicy");

app.Run();

static Action<CertificateAuthenticationOptions> ValidateCertificateHandlerMethod()
{
    return options =>
    {
        options.AllowedCertificateTypes = CertificateTypes.All;
        options.Events = new CertificateAuthenticationEvents
        {
            OnCertificateValidated = context =>
            {
                Console.WriteLine("Validate Certificate");
                var validationService = context.HttpContext.RequestServices.GetRequiredService<ICertificateValidationService>();

                if (!validationService.ValidateCertificate(context.ClientCertificate))
                {
                    context.Fail("Invalid Certificate");
                }

                var claims = new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, context.ClientCertificate.Subject, ClaimValueTypes.String, context.Options.ClaimsIssuer),
                    new Claim(ClaimTypes.Name, context.ClientCertificate.Subject, ClaimValueTypes.String, context.Options.ClaimsIssuer),
                    new Claim("Access", "HasAccess"),
                    new Claim(nameof(ClaimKey), ClaimKey.KaldFraDrkService.ToStringFast())
                };

                context.Principal = new ClaimsPrincipal(
                    new ClaimsIdentity(claims, context.Scheme.Name));
                context.Success();

                return Task.CompletedTask;
            }
        };
    };
}
