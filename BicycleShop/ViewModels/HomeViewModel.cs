using BicycleShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Bike> BikesOfTheWeek { get; set; }
    }
}
