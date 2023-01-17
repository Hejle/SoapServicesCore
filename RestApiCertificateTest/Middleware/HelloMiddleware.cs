using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http.Features.Authentication;
using Microsoft.Extensions.Logging;

namespace RestApiCertificateTest.Middleware
{
    public class HelloMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<HelloMiddleware> _logger;

        public HelloMiddleware(RequestDelegate next, ILogger<HelloMiddleware> logger)
        {
            ArgumentNullException.ThrowIfNull(nameof(next));
            ArgumentNullException.ThrowIfNull(nameof(logger));
            _next = next;
            _logger = logger;
        }

        /// <summary>
        /// Invokes the middleware performing authentication.
        /// </summary>
        /// <param name="context">The <see cref="HttpContext"/>.</param>
        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("Hello from Middleware");
            _logger.LogInformation("Hello from Middleware");
            await _next(context);
        }
    }
}
