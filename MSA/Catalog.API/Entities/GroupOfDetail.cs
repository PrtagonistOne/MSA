using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Enities
{
    public class GroupOfDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string NotesOfGroupOfDetail { get; set; }
        public DateTime DataOfGroupOfDetail { get; set; }
        public ICollection<Detail> Details { get; set; }
    }
}
