using BicycleShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace BicycleShop.ViewModels
{
    public class AdminListViewModel
    {
        public IQueryable<Bike> Bikes { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
