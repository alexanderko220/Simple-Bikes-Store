using BicycleShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BicycleShop.Components
{
    public class SpecificationComponent :ViewComponent
    {
        private readonly ISpecificationRepository  _specificationRepository;
        public SpecificationComponent(ISpecificationRepository  specificationRepository)
        {
            _specificationRepository = specificationRepository;
        }
        public IViewComponentResult Invoke(int id)
        {
            var specification = _specificationRepository.Specifications.FirstOrDefault(s => s.BikeId == id);
            Dictionary<string,object> result = specification.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
          .ToDictionary(prop => prop.Name, prop => prop?.GetValue(specification, null));

            //regex pattern to separate property name
            var pattern = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);

            Dictionary<string, object> spesifications = new Dictionary<string, object>();
            foreach (var item in result)
            {
                if (item.Value != null && item.Key != "BikeId" && item.Key != "Bike")
                {
                    
                    string separeteName = pattern.Replace(item.Key, " ");
                    spesifications.Add(separeteName, item.Value);
                }
                    
            }
            return View(spesifications);
        }
    }
}
