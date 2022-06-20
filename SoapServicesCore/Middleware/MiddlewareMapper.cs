namespace SoapServicesCore.Middleware
{
    public class MiddlewareMapper : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var fbrs = new HeaderObject();
            context.Items.Add("fbrs", fbrs);

            await next.Invoke(context);
        }
    }
}
