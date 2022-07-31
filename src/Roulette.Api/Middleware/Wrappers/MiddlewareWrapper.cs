using Microsoft.AspNetCore.Builder;

namespace Roulette_Project.Middleware.Wrappers
{
    public static class MiddlewareWrapper
    {
        public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ProcessFailureResponseHandlerMiddleware>();
        }
    }
}
