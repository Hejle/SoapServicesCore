using Microsoft.Extensions.Logging;
using SoapServicesCore.Interfaces;
using System;
using System.Security.Cryptography.X509Certificates;

namespace SoapServicesCore.Authentication
{
    public class X509CertificateValidationService : ICertificateValidationService
    {
        private readonly ILogger<X509CertificateValidationService> _logger;

        public X509CertificateValidationService(ILogger<X509CertificateValidationService> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Validate the client certificate
        /// </summary>
        /// <param name="clientCertificate">client certificate <see cref="X509Certificate2"/></param>
        public bool ValidateCertificate(X509Certificate2? clientCertificate)
        {
            if (clientCertificate?.Thumbprint == null)
                return false;
            _logger.LogInformation(clientCertificate.Thumbprint);
            return true;
            //throw new NotImplementedException();
            //return _certificateDataAccessService.GetCertificateByThumbprint(clientCertificate.Thumbprint) != null;
        }
    }
}
