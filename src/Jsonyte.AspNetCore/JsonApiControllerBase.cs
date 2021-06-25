using System.Threading;
using System.Threading.Tasks;
using Jsonyte.AspNetCore.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Jsonyte.AspNetCore
{
    public abstract class JsonApiControllerBase<T> : ControllerBase
    {
        public IRepository<T> Repository => HttpContext.RequestServices.GetService<IRepository<T>>();

        [HttpGet]
        public virtual async Task<IActionResult> GetAsync(CancellationToken token)
        {
            return Ok();
        }

        [HttpPost]
        public virtual async Task<IActionResult> PostAsync(T model, CancellationToken token)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetAsync(string id, CancellationToken token)
        {
            return Ok();
        }

        [HttpPatch("{id}")]
        public virtual async Task<IActionResult> PatchAsync(string id, CancellationToken token)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> DeleteAsync(string id, CancellationToken token)
        {
            return Ok();
        }

        [HttpGet("{id}/{relationship}")]
        public virtual async Task<IActionResult> GetRelatedAsync(string id, string relationship, CancellationToken token)
        {
            return Ok();
        }

        [HttpGet("{id}/relationships/{relationship}")]
        public virtual async Task<IActionResult> GetRelationshipAsync(string id, string relationship, CancellationToken token)
        {
            return Ok();
        }

        [HttpPatch("{id}/relationships/{relationship}")]
        public virtual async Task<IActionResult> PatchRelationshipAsync(string id, string relationship, CancellationToken token)
        {
            return Ok();
        }

        [HttpDelete("{id}/relationships/{relationship}")]
        public virtual async Task<IActionResult> DeleteRelationshipAsync(string id, string relationship, CancellationToken token)
        {
            return Ok();
        }
    }
}
