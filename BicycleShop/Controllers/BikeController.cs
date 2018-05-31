using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BicycleShop.Models;
using BicycleShop.ViewModels;
using System.Reflection;

namespace BicycleShop.Controllers
{
    public class BikeController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IBikeRepository _bikeRepository;

        public BikeController(ICategoryRepository categoryRepository, IBikeRepository bikeRepository)
        {
            _bikeRepository = bikeRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Bike> bikes;
            string currentCutegory = string.Empty;
            if (string.IsNullOrEmpty(category))
            {
                bikes = _bikeRepository.Bikes.OrderBy(b => b.BikeId);
                currentCutegory = "ALL BIKES";
            }
            else
            {
                bikes = _bikeRepository.Bikes.Where(b => b.Category.CategoryName == category)
                    .OrderBy(b => b.BikeId);
                currentCutegory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }
            return View(new BikeListViewModel {
                Bikes = bikes,
                CurrentCategory = currentCutegory
            });
        }

        public IActionResult Details(int id)
        {
            var bike = _bikeRepository.GetBikeById(id);
            if (bike == null)
                return NotFound();
            

            return View(bike);
        }
    }
}