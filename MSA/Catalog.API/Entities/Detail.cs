using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Entities
{
    public class Detail
    {
        public string Id { get; set; }
        public int GroupOfDetailId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public GroupOfDetail GroupOfDetail { get; set; }
    }
}
