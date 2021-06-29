using System.Collections.Generic;
using System.Threading.Tasks;
using Jsonyte.AspNetCore.Example.Models;
using Jsonyte.AspNetCore.Repository;

namespace Jsonyte.AspNetCore.Example.Repositories
{
    public class ArticleRepository : IRepository<Article>
    {
        public Task<IReadOnlyCollection<Article>> GetAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Article> GetAsync(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
