using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Jsonyte.AspNetCore
{
    public abstract class JsonApiControllerBase<T> : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync(CancellationToken token)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(T model, CancellationToken token)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id, CancellationToken token)
        {
            return Ok();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> PostAsync(CancellationToken token)
        {
            return Ok();
        }

        [HttpGet("{id}/{relationship}")]
        public async Task<IActionResult> GetRelationshipAsync(string id, string relationship, CancellationToken token)
        {
            return Ok();
        }
    }
}
