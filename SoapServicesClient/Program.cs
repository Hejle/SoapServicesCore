// See https://aka.ms/new-console-template for more information
using EchoService;
using System;
using System.Net.Http;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;

//Console.WriteLine("Hello, World!");

//var binding = new NetHttpsBinding();
//binding.Security.Mode = BasicHttpsSecurityMode.Transport;
//binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;

//EchoServiceClient client = new EchoServiceClient(binding);

//client.ClientCredentials.ClientCertificate.SetCertificate(
//    StoreLocation.CurrentUser,
//    StoreName.My,
//    X509FindType.FindByThumbprint,
//    "DE2061F9B563FA436B0287621E8142DECDA8B89D");
//client.ClientCredentials.ServiceCertificate.SetDefaultCertificate(
//    StoreLocation.CurrentUser,
//    StoreName.My,
//    X509FindType.FindByThumbprint,
//    "DE2061F9B563FA436B0287621E8142DECDA8B89D");
////client.ClientCredentials.ApplyClientBehavior(client.ClientCredentials);

//var input = "5";
//EchoResponse result = await client.EchoAsync(new EchoRequest(input));

//Console.WriteLine($"With input {input} the result was: {result.EchoResult}");

//client.Close();
//Console.ReadLine();

var httpClient = new HttpClient();

var response = await httpClient.GetAsync("https://localhost:7263/");

if (response.IsSuccessStatusCode)
{
    var message = await response.Content.ReadAsStringAsync();
    Console.WriteLine(message);
}
else
{
    Console.WriteLine("Status for default endpoint");
    Console.WriteLine(response.StatusCode);
}
var handler = new HttpClientHandler();
handler.ClientCertificateOptions = ClientCertificateOption.Manual;
handler.SslProtocols = SslProtocols.Tls12;

var cert = GetCertificateFromStoreCore(StoreLocation.CurrentUser, StoreName.My, X509FindType.FindByThumbprint, "DE2061F9B563FA436B0287621E8142DECDA8B89D");
handler.ClientCertificates.Add(cert);
var client = new HttpClient(handler);

response = await client.GetAsync("https://localhost:7263/Drk");

if (response.IsSuccessStatusCode)
{
    var message = await response.Content.ReadAsStringAsync();
    Console.WriteLine(message);
} else
{
    Console.WriteLine("Status for drk endpoint");
    Console.WriteLine(response.StatusCode);
}


static X509Certificate2 GetCertificateFromStoreCore(StoreLocation storeLocation, StoreName storeName, X509FindType findType, object findValue)
{
    ArgumentNullException.ThrowIfNull(nameof(findValue));
    var store = new X509Store(storeName, storeLocation);
    X509Certificate2Collection certs = null!;
    try
    {
        store.Open(OpenFlags.ReadOnly);
        certs = store.Certificates.Find(findType, findValue, false);
        if (certs.Count == 1)
        {
            return new X509Certificate2(certs[0]);
        }

        if (certs.Count == 0)
                throw new InvalidOperationException("Cannot find certificate");
            throw new InvalidOperationException("Multiple certificates were found");
    }
    finally
    {
        ResetAllCertificates(certs);
        store.Dispose();
    }
}

static void ResetAllCertificates(X509Certificate2Collection certificates)
{
    if (certificates != null)
    {
        for (int i = 0; i < certificates.Count; ++i)
        {
            certificates[i].Dispose();
        }
    }
}