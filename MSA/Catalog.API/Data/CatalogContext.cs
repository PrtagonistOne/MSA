using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.API.Data.Interfaces;
using Catalog.API.Entities;
using MongoDB.Driver;
namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {


        public IMongoCollection<Detail> Details { get; }
        public IMongoCollection<GroupOfDetail> GroupOfDetails { get; }


    }
}
