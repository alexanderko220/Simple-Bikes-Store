using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BicycleShop.Models;
using BicycleShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BicycleShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBikeRepository _bikeRepository;

        public HomeController(IBikeRepository  bikeRepository)
        {
            _bikeRepository = bikeRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                BikesOfTheWeek = _bikeRepository.BikesOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}