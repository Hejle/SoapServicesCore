using CoreWCF;
using SoapServicesCore.ServiceContracts;

namespace SoapServicesCore
{
    public class EchoService : IEchoService
    {

        public string Echo(string text)
        {
            if(int.TryParse(text, out var result))
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
    }
}
