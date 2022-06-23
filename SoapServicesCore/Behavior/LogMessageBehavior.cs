using CoreWCF.Channels;
using CoreWCF.Description;
using CoreWCF.Dispatcher;

namespace SoapServicesCore.Behavior
{
    public class LogMessageBehavior : IEndpointBehavior
    {
        private readonly LogMessageInspector _validateUserInspector;

        public LogMessageBehavior(LogMessageInspector validateUserInspector)
        {
            _validateUserInspector = validateUserInspector;
        }

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
            endpointDispatcher.DispatchRuntime.MessageInspectors.Add(_validateUserInspector);
        }

        public void Validate(ServiceEndpoint endpoint)
        {
        }
    }
}
