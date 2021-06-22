using Jsonyte.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.DependencyInjection;

namespace Jsonyte.AspNetCore
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddJsonyteJsonApi(this IServiceCollection services)
        {
            services
                .AddMvcCore(options =>
                {
                    options.EnableEndpointRouting = true;
                    options.Conventions.Insert(0, new JsonApiModelConvention());
                });

            return services;
        }
    }
}
