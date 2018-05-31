using BicycleShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleShop.ViewModels
{
    public class AdminCreateViewModel
    {
        public Bike Bike { get; set; }
        public Specification Specification { get; set; }
    }
}
