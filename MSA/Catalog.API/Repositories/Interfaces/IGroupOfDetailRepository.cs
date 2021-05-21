using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog.API.Entities;

namespace Catalog.API.Repositories.Interfaces
{
    public interface IGroupOfDetailRepository
    {
        Task<IEnumerable<GroupOfDetail>> GetGroupOfDetails();

        Task CreateGroupOfDetail (GroupOfDetail detail);
        Task<bool> UpdateGroupOfDetail (GroupOfDetail detail);
        Task<bool> DeleteGroupOfDetail(string id);
    }
}
