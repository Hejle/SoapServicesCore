using CoreWCF;
using Microsoft.AspNetCore.Authorization;

namespace SoapServicesCore.ServiceContracts;

[ServiceContract(Name = "IEchoService")]
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

