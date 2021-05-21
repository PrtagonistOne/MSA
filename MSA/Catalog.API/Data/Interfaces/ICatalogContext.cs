using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Catalog.API.Entities;

namespace Catalog.API.Data.Interfaces
{
    public interface ICatalogContext
    {
        IMongoCollection<Detail> Detail { get; }
        IMongoCollection<GroupOfDetail> GroupOfDetail { get; }

    }
}
