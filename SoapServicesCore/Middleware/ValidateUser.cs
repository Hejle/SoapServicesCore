using CoreWCF;

namespace SoapServicesCore.Middleware
{
    public class ValidateUser : IMiddleware
    {

        private readonly string TrustedUser = "joachim-dk@hotmail.com";

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (!context.User.IsInRole(TrustedUser))
                throw new FaultException<UnauthorizedAccessException>(new UnauthorizedAccessException("User is not trusted"));
            await next.Invoke(context);
        }
    }
}
