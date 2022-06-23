using CoreWCF;
using CoreWCF.Channels;
using CoreWCF.Configuration;
using CoreWCF.Description;
using SoapServicesCore;
using SoapServicesCore.Behavior;
using SoapServicesCore.Logging;
using SoapServicesCore.ServiceContracts;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.ConfigureKestrel((context, options) =>
{
    options.AllowSynchronousIO = true;
});

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddSingleton<LogMessageBehavior>();
builder.Services.AddSingleton<LogMessageInspector>();

// Add WSDL support
builder.Services.AddServiceModelServices().AddServiceModelMetadata();
builder.Services.AddSingleton<IServiceBehavior, UseRequestHeadersForMetadataAddressBehavior>();

var app = builder.Build();

app.UseMiddleware<LogHeadersMiddleware>();

app.UseServiceModel(builder =>
{
    builder
    .AddService<EchoService>(serviceOptions =>
    {
        serviceOptions.DebugBehavior.IncludeExceptionDetailInFaults = true;
        serviceOptions.BaseAddresses.Add(new Uri("http://localhost/EchoService.svc"));
    })
    .AddServiceEndpoint<EchoService, IEchoService>(new BasicHttpBinding(), "/EchoService", endpointOptions =>
    {
        endpointOptions.EndpointBehaviors.Add(app.Services.GetRequiredService<LogMessageBehavior>());
    })
    .AddService<EchoService>(serviceOptions =>
    {
        serviceOptions.DebugBehavior.IncludeExceptionDetailInFaults = true;
        serviceOptions.BaseAddresses.Add(new Uri("https://localhost/EchoService.svc"));
    })
    // Add a BasicHttpBinding at a specific endpoint with Behavior
    .AddServiceEndpoint<EchoService, IEchoService>(new BasicHttpBinding(BasicHttpSecurityMode.Transport), "/EchoService", endpointOptions =>
    {
        endpointOptions.EndpointBehaviors.Add(app.Services.GetRequiredService<LogMessageBehavior>());
    });
});

var serviceMetadataBehavior = app.Services.GetRequiredService<ServiceMetadataBehavior>();
serviceMetadataBehavior.HttpGetEnabled = true;
serviceMetadataBehavior.HttpsGetEnabled = true;

app.Run();