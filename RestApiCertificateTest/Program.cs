using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Server.Kestrel.Https;
using Microsoft.Extensions.DependencyInjection;
using RestApiCertificateTest;
using RestApiCertificateTest.Middleware;
using SoapServicesCore.Authentication;
using SoapServicesCore.Interfaces;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.AddConsole();
//builder.Services.Configure<KestrelServerOptions>(kestrelServerOptions =>
//{
//    kestrelServerOptions.ConfigureEndpointDefaults(options =>
//    {
//        options.UseConnectionLogging();
//    });
//    kestrelServerOptions.ConfigureHttpsDefaults(httpsConnectionAdapterOptions =>
//    {
//        httpsConnectionAdapterOptions.ClientCertificateMode = ClientCertificateMode.RequireCertificate;
//        httpsConnectionAdapterOptions.AllowAnyClientCertificate();
//    });
//});
builder.Services.AddScoped<ICertificateValidationService, X509CertificateValidationService>();

builder.Services.AddAuthentication(CertificateAuthenticationDefaults.AuthenticationScheme)
    .AddCertificate(ValidateCertificateHandlerMethod());
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("DrkWebseriveOnly", policy => policy.RequireClaim(ClaimKey.KaldFraDrkService.ToStringFast()));
});
var app = builder.Build();
app.UseMiddleware<HelloMiddleware>();
app.UseAuthentication();
app.UseAuthentication();
//app.UseHttpsRedirection();
//app.UseMiddleware<MyAuthenticationMiddleware>();
//app.UseAuthentication();

app.MapGet("/", () => "Hello from Rest service!");

app.MapGet("/Drk", () => "Hello from DRK service!").RequireAuthorization("DrkWebseriveOnly");

app.Run();

[Authorize()]
static Action<CertificateAuthenticationOptions> ValidateCertificateHandlerMethod()
{
    return options =>
    {
        options.AllowedCertificateTypes = CertificateTypes.All;
        options.Events = new CertificateAuthenticationEvents
        {
            OnChallenge = certificateChallengeContext =>
            {
                Console.WriteLine("On Challenge failed");
                Console.WriteLine(certificateChallengeContext);
                return Task.CompletedTask;
            },
            OnAuthenticationFailed = context =>
            {
                Console.WriteLine("Auth failed");
                context.Success();
                return Task.CompletedTask;
            },
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
                    new Claim(ClaimValueTypes.String, ClaimKey.KaldFraDrkService.ToStringFast())
                };

                context.Principal = new ClaimsPrincipal(
                    new ClaimsIdentity(claims, context.Scheme.Name));
                context.Success();

                return Task.CompletedTask;
            }
        };
    };
}
