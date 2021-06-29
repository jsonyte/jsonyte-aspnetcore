using Jsonyte.AspNetCore.Middleware;
using Jsonyte.AspNetCore.Mvc;
using Jsonyte.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

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

            services.TryAddEnumerable(ServiceDescriptor.Transient<IConfigureOptions<MvcOptions>, JsonApiMvcOptions>());

            return services;
        }
    }
}
