using CoreWCF;
using CoreWCF.Channels;
using CoreWCF.Dispatcher;

namespace SoapServicesCore.Behavior
{
    public class LogMessageInspector : IDispatchMessageInspector
    {
        private readonly ILogger _logger;

        public LogMessageInspector(ILogger<LogMessageInspector> logger)
        {
            _logger = logger;
        }

        public object AfterReceiveRequest(ref Message request, IClientChannel channel, InstanceContext instanceContext)
        {
            _logger.LogCritical(request.ToString());
            return 1;
        }

        public void BeforeSendReply(ref Message reply, object correlationState)
        {
            _logger.LogCritical(reply.ToString());
        }
    }
}
