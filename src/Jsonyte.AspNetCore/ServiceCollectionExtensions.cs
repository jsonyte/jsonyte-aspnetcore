using Jsonyte.AspNetCore.Middleware;
using Jsonyte.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.DependencyInjection;

namespace Jsonyte.AspNetCore
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddJsonApi(this IServiceCollection services)
        {
            services
                .AddSingleton<JsonApiRouteMiddleware>()
                .AddMvcCore(options =>
                {
                    options.EnableEndpointRouting = true;
                    options.Conventions.Insert(0, new JsonApiModelConvention());
                });

            return services;
        }
    }
}
