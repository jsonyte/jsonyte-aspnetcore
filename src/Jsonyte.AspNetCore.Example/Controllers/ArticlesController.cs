using Jsonyte.AspNetCore.Example.Models;
using Microsoft.Extensions.Logging;

namespace Jsonyte.AspNetCore.Example.Controllers
{
    public class ArticlesController : JsonApiController<Article>
    {
        public ArticlesController(IJsonApiOptions options, ILoggerFactory loggerFactory, IResourceService<Article> resourceService)
            : base(options, loggerFactory, resourceService)
        {
        }
    }
}
