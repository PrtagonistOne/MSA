using Catalog.API.Data.Interfaces;
using Catalog.API.Entities;
using Catalog.API.Repositories.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Repositories
{
    public class DetailRepository : IDetailRepository
    {
        private readonly ICatalogContext _context;

        public DetailRepository(ICatalogContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Detail>> GetDetails()
        {
            return await _context
                            .Detail
                            .Find(p => true)
                            .ToListAsync();
        }


        public async Task CreateDetail(Detail detail)
        {
            await _context.Detail.InsertOneAsync(detail);
        }

        public async Task<bool> UpdateDetail(Detail detail)
        {
            var updateResult = await _context
                                        .Detail
                                        .ReplaceOneAsync(filter: g => g.Id == detail.Id, replacement: detail);

            return updateResult.IsAcknowledged
                    && updateResult.ModifiedCount > 0;
        }

        public async Task<bool> DeleteDetail(string id)
        {
            FilterDefinition<Detail> filter = Builders<Detail>.Filter.Eq(p => p.Id, id);

            DeleteResult deleteResult = await _context
                                                .Detail
                                                .DeleteOneAsync(filter);

            return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;
        }
    }
}
