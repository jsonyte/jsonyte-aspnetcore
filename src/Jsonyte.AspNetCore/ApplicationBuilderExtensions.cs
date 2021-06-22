using Jsonyte.AspNetCore.Middleware;
using Microsoft.AspNetCore.Builder;

namespace Jsonyte.AspNetCore
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseJsonyteJsonApi(this IApplicationBuilder builder)
        {
            return builder
                .UseMiddleware<JsonApiRouteMiddleware>();
        }
    }
}
