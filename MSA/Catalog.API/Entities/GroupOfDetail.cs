using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Entities
{
    public class GroupOfDetail
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string NotesOfGroupOfDetail { get; set; }
        public DateTime DateOfGroupOfDetail { get; set; }
        public ICollection<Detail> Details { get; set; }
    }
}
