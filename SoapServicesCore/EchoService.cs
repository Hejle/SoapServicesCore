using CoreWCF;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using SoapServicesCore.ServiceContracts;
using System;
using System.Security.Principal;
using System.Threading;

namespace SoapServicesCore
{
    public class EchoService : IEchoService
    {
        private readonly ILogger _logger;

        public EchoService(ILogger<EchoService> logger)
        {
            _logger = logger;
        }

        public string Echo(string text)
        {
            if (int.TryParse(text, out var result))
            {
                return (result+1).ToString();
            }
            return text;
        }

        [Authorize]
        public string ComplexEcho(EchoMessage text)
        {
            if(text is null)
            {
                return String.Empty;
            }
            return text.Text;
        }

        public string FailEcho(string text)
            => throw new FaultException<EchoFault>(new EchoFault() { Text = "WCF Fault OK" }, new FaultReason("FailReason"));

        public PingOutput Ping()
        {
            return new PingOutput() { Result = true };
        }
    }
}
