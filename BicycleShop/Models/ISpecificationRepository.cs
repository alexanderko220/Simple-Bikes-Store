using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleShop.Models
{
    public interface ISpecificationRepository
    {
        IEnumerable<Specification> Specifications { get; }
        
    }
}
