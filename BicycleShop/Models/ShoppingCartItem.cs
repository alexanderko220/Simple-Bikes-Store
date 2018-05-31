using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleShop.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Bike Bike { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
