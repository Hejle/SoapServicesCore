using CoreWCF;
using Microsoft.AspNetCore.Authorization;

namespace SoapServicesCore.ServiceContracts;

[ServiceContract(Name = "IEchoService", Namespace = "http://rep.oio.dk/inm.dk/2008/08/18/")]
public interface IEchoService
{
    [OperationContract]
    string Echo(string text);

    [OperationContract]
    string ComplexEcho(EchoMessage text);

    [OperationContract]
    [FaultContract(typeof(EchoFault))]
    string FailEcho(string text);

    [OperationContract]
    [FaultContract(typeof(EchoFault))]
    PingOutput Ping();
}

