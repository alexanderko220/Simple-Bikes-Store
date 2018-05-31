using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext context;
        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        public IEnumerable<Category> Categories => context.Categories;
    }
}
