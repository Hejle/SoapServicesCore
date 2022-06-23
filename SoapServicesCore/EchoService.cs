using CoreWCF;
using SoapServicesCore.ServiceContracts;
using System.Security.Principal;

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
            ValidateUser();
            if (int.TryParse(text, out var result))
            {
                return (result+1).ToString();
            }
            return text;
        }

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

        private void ValidateUser()
        {
            IPrincipal clientUser = Thread.CurrentPrincipal;
            if(clientUser == null)
            {
                _logger.LogInformation("User was null");
                throw new FaultException<EchoFault>(new EchoFault() { Text = "Not logged In" }, new FaultReason("SecurityException"));
            }
        }
    }
}
