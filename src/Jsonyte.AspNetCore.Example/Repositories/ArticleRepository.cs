using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using JsonApiDotNetCore.Queries;
using JsonApiDotNetCore.Queries.Expressions;
using JsonApiDotNetCore.Repositories;
using JsonApiDotNetCore.Resources;
using Jsonyte.AspNetCore.Example.Models;

namespace Jsonyte.AspNetCore.Example.Repositories
{
    public class ArticleRepository : IResourceRepository<Article>
    {
        public Task<IReadOnlyCollection<Article>> GetAsync(QueryLayer layer, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> CountAsync(FilterExpression topFilter, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<Article> GetForCreateAsync(int id, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(Article resourceFromRequest, Article resourceForDatabase, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<Article> GetForUpdateAsync(QueryLayer queryLayer, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Article resourceFromRequest, Article resourceFromDatabase, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task SetRelationshipAsync(Article primaryResource, object secondaryResourceIds, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task AddToToManyRelationshipAsync(int primaryId, ISet<IIdentifiable> secondaryResourceIds, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveFromToManyRelationshipAsync(Article primaryResource, ISet<IIdentifiable> secondaryResourceIds, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
