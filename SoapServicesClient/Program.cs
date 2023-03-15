using System;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

var certificatePath = Path.Combine(Assembly.GetExecutingAssembly().Location, "certificatename.pfx");

var cert = new X509Certificate2(certificatePath, "netcompany-1234");
var handler = new HttpClientHandler();
handler.ClientCertificates.Add(cert);
var client = new HttpClient(handler);

var responseCert = await client.GetAsync("https://localhost:7263/SecureService");

if (responseCert.IsSuccessStatusCode)
{
    var message = await responseCert.Content.ReadAsStringAsync();
    Console.WriteLine(message);
} else
{
    Console.WriteLine(responseCert.StatusCode);
}