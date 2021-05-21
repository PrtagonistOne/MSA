using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Models
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string GroupOfDetailCollectionName { get; set; }
        public string DetailCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
    public interface IDatabaseSettings
    {
        string GroupOfDetailCollectionName { get; set; }
        string DetailCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
