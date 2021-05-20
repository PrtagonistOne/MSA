using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Entities
{
    public class Detail
    {
        public int Id { get; set; }
        public int GroupOfDetailId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public GroupOfDetail GroupOfDetail { get; set; }
    }
}
