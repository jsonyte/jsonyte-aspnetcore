using System.Threading;
using System.Threading.Tasks;
using Jsonyte.AspNetCore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Jsonyte.AspNetCore
{
    public abstract class JsonApiControllerBase<T> : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync([FromServices] IRepository<T> repository, CancellationToken token)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromServices] IRepository<T> repository, T model, CancellationToken token)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromServices] IRepository<T> repository, string id, CancellationToken token)
        {
            return Ok();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchAsync([FromServices] IRepository<T> repository, string id, CancellationToken token)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromServices] IRepository<T> repository, string id, CancellationToken token)
        {
            return Ok();
        }

        [HttpGet("{id}/{relationship}")]
        public async Task<IActionResult> GetRelatedAsync([FromServices] IRepository<T> repository, string id, string relationship, CancellationToken token)
        {
            return Ok();
        }

        [HttpGet("{id}/relationships/{relationship}")]
        public async Task<IActionResult> GetRelationshipAsync([FromServices] IRepository<T> repository, string id, string relationship, CancellationToken token)
        {
            return Ok();
        }

        [HttpPatch("{id}/relationships/{relationship}")]
        public async Task<IActionResult> PatchRelationshipAsync([FromServices] IRepository<T> repository, string id, string relationship, CancellationToken token)
        {
            return Ok();
        }

        [HttpDelete("{id}/relationships/{relationship}")]
        public async Task<IActionResult> DeleteRelationshipAsync([FromServices] IRepository<T> repository, string id, string relationship, CancellationToken token)
        {
            return Ok();
        }
    }
}
