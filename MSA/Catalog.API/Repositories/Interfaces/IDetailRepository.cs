using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog.API.Entities;

namespace Catalog.API.Repositories.Interfaces
{
    public interface IDetailRepository
    {
        Task<IEnumerable<Detail>> GetProducts();

        Task CreateDetail (Detail detail);
        Task<bool> UpdateDetail (Detail detail);
        Task<bool> DeleteDetail (string id);
    }
}
