using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jsonyte.AspNetCore.Repository
{
    public interface IRepository<T>
    {
        Task<IReadOnlyCollection<T>> GetAsync();

        Task<T> GetAsync(string id);
    }
}
