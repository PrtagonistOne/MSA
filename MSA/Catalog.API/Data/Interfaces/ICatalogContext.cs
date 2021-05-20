using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Catalog.API.Entities;

namespace Catalog.API.Data.Interfaces
{
    interface ICatalogContext
    {
        IMongoCollection<Detail> Details { get; }
        IMongoCollection<GroupOfDetail> GroupOfDetails { get; }

    }
}
