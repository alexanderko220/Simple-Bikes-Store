using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleShop.Models
{
    public class BikeRepository :IBikeRepository
    {
        private readonly ApplicationDbContext context;
        public BikeRepository(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        public IQueryable<Bike> Bikes => context.Bikes.Include(c => c.Category).Include(s => s.Specifications);

        public IQueryable<Bike> BikesOfTheWeek => context.Bikes.Include(c => c.Category).Include(s => s.Specifications).Where(b => b.IsBikeOfTheWeek);

        public Bike GetBikeById(int bikeId) => context.Bikes.FirstOrDefault(b => b.BikeId == bikeId);

       
          
      
    }
}
