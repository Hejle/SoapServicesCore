using CoreWCF;
using CoreWCF.Channels;
using CoreWCF.Configuration;
using CoreWCF.Description;
using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Server.Kestrel.Https;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SoapServicesCore;
using SoapServicesCore.Authentication;
using SoapServicesCore.Behavior;
using SoapServicesCore.Interfaces;
using SoapServicesCore.Logging;
using SoapServicesCore.ServiceContracts;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.Configure<KestrelServerOptions>(kestrelServerOptions =>
//{
//    kestrelServerOptions.AllowSynchronousIO = true;
//    kestrelServerOptions.ConfigureHttpsDefaults(httpsConnectionAdapterOptions =>
//    {
//        //// To be able to see the swagger links, set this to ClientCertificateMode.DelayCertificate
//        httpsConnectionAdapterOptions.ClientCertificateMode = ClientCertificateMode.RequireCertificate;
//    };
//    };

builder.Services.AddScoped<ICertificateValidationService, X509CertificateValidationService>();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddAuthentication(CertificateAuthenticationDefaults.AuthenticationScheme)
//builder.Services.AddAuthentication(CertificateAuthenticationDefaults.AuthenticationScheme)
    .AddCertificate();

builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = options.DefaultPolicy;
});
builder.Services.AddScoped<EchoService>();
builder.Services.AddSingleton<LogMessageBehavior>();
builder.Services.AddSingleton<LogMessageInspector>();

// Add WSDL support
builder.Services.AddServiceModelServices().AddServiceModelMetadata();
builder.Services.AddSingleton<IServiceBehavior, UseRequestHeadersForMetadataAddressBehavior>();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.UseServiceModel(builder =>
{
    builder
    .AddService<EchoService>(serviceOptions =>
    {
        serviceOptions.DebugBehavior.IncludeExceptionDetailInFaults = true;
        serviceOptions.BaseAddresses.Add(new Uri("https://localhost/EchoService.svc"));
    })
    .AddServiceEndpoint<EchoService, IEchoService>(
        new BasicHttpBinding
        {
            Security = new BasicHttpSecurity
            {
                Mode = BasicHttpSecurityMode.Transport,
                Transport = new HttpTransportSecurity
                {
                    ClientCredentialType = HttpClientCredentialType.InheritedFromHost
                }
            }
        }, "/EchoService", endpointOptions =>
        {
            //endpointOptions.EndpointBehaviors.Add(app.Services.GetRequiredService<LogMessageBehavior>());
        });
});

var serviceMetadataBehavior = app.Services.GetRequiredService<ServiceMetadataBehavior>();
serviceMetadataBehavior.HttpsGetEnabled = true;

app.Run();

static Action<CertificateAuthenticationOptions> ValidateCertificateHandlerMethod()
{
    return options =>
    {
        options.AllowedCertificateTypes = CertificateTypes.All;
        options.ValidateValidityPeriod = true;
        options.Events = new CertificateAuthenticationEvents
        {
            OnChallenge = context =>
            {
                Console.WriteLine("On Challenge failed");
                Console.WriteLine(context);
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
                Console.WriteLine("Auth Success");
                var validationService = context.HttpContext.RequestServices.GetRequiredService<ICertificateValidationService>();

                if(!validationService.ValidateCertificate(context.ClientCertificate))
                {
                    context.Fail("Invalid Certificate");
                }

                var claims = new[]
                {
                    new Claim(
                        ClaimTypes.NameIdentifier,
                        context.ClientCertificate.Subject,
                        ClaimValueTypes.String, context.Options.ClaimsIssuer),
                    new Claim(
                        ClaimTypes.Name,
                        context.ClientCertificate.Subject,
                        ClaimValueTypes.String, context.Options.ClaimsIssuer)
                };

                context.Principal = new ClaimsPrincipal(
                    new ClaimsIdentity(claims, context.Scheme.Name));
                context.Success();

                return Task.CompletedTask;
            }
        };
    };
}