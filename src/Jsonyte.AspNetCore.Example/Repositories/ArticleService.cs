using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Services;
using Jsonyte.AspNetCore.Example.Models;

namespace Jsonyte.AspNetCore.Example.Repositories
{
    public class ArticleService : IResourceService<Article>
    {
        public Task<Article> CreateAsync(Article resource, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task AddToToManyRelationshipAsync(int primaryId, string relationshipName, ISet<IIdentifiable> secondaryResourceIds, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<Article> UpdateAsync(int id, Article resource, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task SetRelationshipAsync(int primaryId, string relationshipName, object secondaryResourceIds, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveFromToManyRelationshipAsync(int primaryId, string relationshipName, ISet<IIdentifiable> secondaryResourceIds, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IReadOnlyCollection<Article>> GetAsync(CancellationToken cancellationToken)
        {
            return new Article[]
            {
                new Article
                {
                    Id = 1,
                    Title = "Jsonapi",
                    Tags = new List<Tag>
                    {
                        new Tag
                        {
                            Id = 4,
                            Value = "web"
                        }
                    }
                },
                new Article
                {
                    Id = 2,
                    Title = "Jsonapi 2",
                    Tags = new List<Tag>
                    {
                        new Tag
                        {
                            Id = 4,
                            Value = "web"
                        }
                    }
                },
            };
        }

        public Task<Article> GetAsync(int id, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<object> GetRelationshipAsync(int id, string relationshipName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<object> GetSecondaryAsync(int id, string relationshipName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
