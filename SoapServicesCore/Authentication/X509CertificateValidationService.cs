using Microsoft.Extensions.Logging;
using SoapServicesCore.Interfaces;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SoapServicesCore.Authentication
{
    public class X509CertificateValidationService : ICertificateValidationService
    {
        private readonly ILogger<X509CertificateValidationService> _logger;
        private readonly string[] _validThumbprints = new[]
        {
            "92df3325199bde39185694bd126e92d0da3f5c8a",
            "9eb07355037b3599a94e7e01d435d13ae02b6122"
        };


        public X509CertificateValidationService(ILogger<X509CertificateValidationService> logger)
        {
            _logger = logger;
            //92df3325199bde39185694bd126e92d0da3f5c8a
            //9eb07355037b3599a94e7e01d435d13ae02b6122
        }

        /// <summary>
        /// Validate the client certificate
        /// </summary>
        /// <param name="clientCertificate">client certificate <see cref="X509Certificate2"/></param>
        public bool ValidateCertificate(X509Certificate2? clientCertificate)
        {
            if (clientCertificate?.Thumbprint == null)
                return false;
            return _validThumbprints.Contains(clientCertificate.Thumbprint.ToLower());
            //return _certificateDataAccessService.GetCertificateByThumbprint(clientCertificate.Thumbprint) != null;
        }
    }
}
