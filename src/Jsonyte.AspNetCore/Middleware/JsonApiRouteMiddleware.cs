using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Jsonyte.AspNetCore.Middleware
{
    public class JsonApiRouteMiddleware : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var values = context.GetRouteData();

            return next(context);
        }
    }
}
