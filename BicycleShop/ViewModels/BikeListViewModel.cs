using BicycleShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleShop.ViewModels
{
    public class BikeListViewModel
    {
        public IEnumerable<Bike> Bikes { get; set; }
        public string CurrentCategory { get; set; }
        
    }
}
