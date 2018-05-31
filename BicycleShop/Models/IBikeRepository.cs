using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleShop.Models
{
    public interface IBikeRepository
    {
        IQueryable<Bike> Bikes { get; }
        IQueryable<Bike> BikesOfTheWeek { get; }
        Bike GetBikeById(int bikeId);
       
    }
}
