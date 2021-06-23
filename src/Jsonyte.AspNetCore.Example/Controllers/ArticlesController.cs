using Jsonyte.AspNetCore.Example.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jsonyte.AspNetCore.Example.Controllers
{
    [Route("api/v1/articles")]
    public class ArticlesController : JsonApiControllerBase<Article>
    {
    }
}
