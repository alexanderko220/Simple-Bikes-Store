using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BicycleShop.Models;
using BicycleShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BicycleShop.Controllers
{
    public class CartController : Controller
    {
        private readonly IBikeRepository _bikeRepository;
        private readonly ShoppingCart _shoppingCart;

        public CartController(IBikeRepository bikeRepository, ShoppingCart shoppingCart)
        {
            _bikeRepository = bikeRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new CartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int bikeId)
        {
            var selectedBike = _bikeRepository.Bikes.FirstOrDefault(b => b.BikeId == bikeId);

            if (selectedBike != null)
            {
                _shoppingCart.AddToCart(selectedBike, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int bikeId)
        {
            var selectedBike = _bikeRepository.Bikes.FirstOrDefault(b => b.BikeId == bikeId);

            if (selectedBike != null)
            {
                _shoppingCart.RemoveFromCart(selectedBike);
            }
            return RedirectToAction("Index");
        }
    }
}