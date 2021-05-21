using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class CatalogModel
    {
        public string Id { get; set; }
        public string DetailDescription { get; set; }
        public string GroupOfDetailDescription { get; set; }
        public string NotesOfGroupOfDetail { get; set; }
        public DateTime DateOfGroupOfDetail { get; set; }
        public int GroupOfDetailId { get; set; }
        public double Price { get; set; }
    }
}
