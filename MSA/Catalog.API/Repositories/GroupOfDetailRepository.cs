using Catalog.API.Data.Interfaces;
using Catalog.API.Entities;
using Catalog.API.Repositories.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Repositories
{
    public class GroupOfDetailRepository : IGroupOfDetailRepository
    {
        private readonly ICatalogContext _context;

        public GroupOfDetailRepository(ICatalogContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<GroupOfDetail>> GetGroupOfDetails()
        {
            return await _context
                            .GroupOfDetail
                            .Find(p => true)
                            .ToListAsync();
        }


        public async Task CreateGroupOfDetail(GroupOfDetail groupOfDetail)
        {
            await _context.GroupOfDetail.InsertOneAsync(groupOfDetail);
        }

        public async Task<bool> UpdateGroupOfDetail(GroupOfDetail groupOfDetail)
        {
            var updateResult = await _context
                                        .GroupOfDetail
                                        .ReplaceOneAsync(filter: g => g.Id == groupOfDetail.Id, replacement: groupOfDetail);

            return updateResult.IsAcknowledged
                    && updateResult.ModifiedCount > 0;
        }

        public async Task<bool> DeleteGroupOfDetail(string id)
        {
            FilterDefinition<GroupOfDetail> filter = Builders<GroupOfDetail>.Filter.Eq(p => p.Id, id);

            DeleteResult deleteResult = await _context
                                                .GroupOfDetail
                                                .DeleteOneAsync(filter);

            return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;
        }
    }
}
