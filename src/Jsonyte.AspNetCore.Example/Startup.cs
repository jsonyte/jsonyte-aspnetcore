using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Services;
using Jsonyte.AspNetCore.Example.Models;
using Jsonyte.AspNetCore.Example.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Jsonyte.AspNetCore.Example
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<IResourceService<Article>, ArticleService>()
                .AddResourceRepository<ArticleRepository>();

            services.AddControllers();

            services
                .AddJsonApi(x => { }, x => x.AddCurrentAssembly())
                .AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app
                .UseSwagger()
                .UseSwaggerUI(x => x.SwaggerEndpoint("/swagger/v1/swagger.json", "Example API v1"))
                .UseRouting()
                .UseJsonApi();

            app
                .UseAuthorization()
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
        }
    }
}
