using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleShop.Models
{
    public class SpecificationRepository : ISpecificationRepository
    {
        private readonly ApplicationDbContext context;
        public SpecificationRepository(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        public IEnumerable<Specification> Specifications => context.Specifications;

        
        
    }
}
