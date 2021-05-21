using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Entities
{
    public class ShoppingCartItem
    {
        public int Quantity { get; set; }
        public int DetailPrice { get; set; }
        public string DetailID { get; set; }
        public string DetailDescription { get; set; }
    }
}
