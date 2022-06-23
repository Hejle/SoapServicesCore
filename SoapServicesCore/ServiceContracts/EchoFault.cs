using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace SoapServicesCore.ServiceContracts;

[DataContract]
public class EchoFault
{
    [AllowNull]
    private string _text;

    [DataMember]
    [AllowNull]
    public string Text
    {
        get { return _text; }
        set { _text = value; }
    }
}