using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using CoreWCF;

namespace SoapServicesCore.ServiceContracts;

[DataContract]

public class EchoMessage
{
    [AllowNull]
    [DataMember]
    public string Text { get; set; }
}