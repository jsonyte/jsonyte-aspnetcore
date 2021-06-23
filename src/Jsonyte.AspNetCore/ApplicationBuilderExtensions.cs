using Jsonyte.AspNetCore.Middleware;
using Microsoft.AspNetCore.Builder;

namespace Jsonyte.AspNetCore
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseJsonApi(this IApplicationBuilder builder)
        {
            return builder
                .UseMiddleware<JsonApiRouteMiddleware>();
        }
    }
}
