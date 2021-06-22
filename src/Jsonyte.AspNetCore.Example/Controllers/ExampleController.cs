using Microsoft.AspNetCore.Mvc;

namespace Jsonyte.AspNetCore.Example.Controllers
{
    [ApiController]
    [Route("api/examples")]
    public class ExampleController : JsonApiControllerBase<Example>
    {
    }
}
