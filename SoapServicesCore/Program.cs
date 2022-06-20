using CoreWCF;
using CoreWCF.Configuration;
using CoreWCF.Description;
using SoapServicesCore;
using SoapServicesCore.Logging;
using SoapServicesCore.Middleware;
using SoapServicesCore.ServiceContracts;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.ConfigureKestrel((context, options) =>
{
    options.AllowSynchronousIO = true;
});

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddTransient<MiddlewareMapper>();
builder.Services.AddTransient<ValidateUser>();
// Add WSDL support
builder.Services.AddServiceModelServices().AddServiceModelMetadata();
builder.Services.AddSingleton<IServiceBehavior, UseRequestHeadersForMetadataAddressBehavior>();
//builder.Services.AddServiceModelConfigurationManagerFile("wcf.config");



var app = builder.Build();

app.UseMiddleware<ValidateUser>();
app.UseMiddleware<MiddlewareMapper>();
app.UseMiddleware<LogHeadersMiddleware>();


app.UseServiceModel(builder =>
{
    builder
    .AddService<EchoService>(serviceOptions =>
    {
        serviceOptions.DebugBehavior.IncludeExceptionDetailInFaults = true;
        serviceOptions.BaseAddresses.Add(new Uri("http://localhost/EchoService.svc"));
    })
    // Add a BasicHttpBinding at a specific endpoint
    .AddServiceEndpoint<EchoService, IEchoService>(new BasicHttpBinding(), "/EchoService");
});

var serviceMetadataBehavior = app.Services.GetRequiredService<ServiceMetadataBehavior>();
serviceMetadataBehavior.HttpGetEnabled = true;

app.Run();