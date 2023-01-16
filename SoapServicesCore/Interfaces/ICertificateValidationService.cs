using System.Security.Cryptography.X509Certificates;

namespace SoapServicesCore.Interfaces
{
    public interface ICertificateValidationService
    {
        /// <summary>
        /// Interface class for certificate thumbprint validation service
        /// </summary>
        /// <param name="clientCertificate"></param>
        bool ValidateCertificate(X509Certificate2? clientCertificate);
    }
}
