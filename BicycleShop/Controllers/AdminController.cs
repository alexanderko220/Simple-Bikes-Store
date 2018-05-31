using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BicycleShop.Models;
using BicycleShop.ViewModels;

namespace BicycleShop.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public int pageSize = 4;
        public AdminController(ApplicationDbContext context)
        {
            _context = context;
            
        }

        // GET: Admin
        public IActionResult Index(string sort, string search, int page = 1)
        {
            ViewBag.CategorySort = String.IsNullOrEmpty(sort) ? "category_desc" : string.Empty;
            ViewBag.ModelSort = sort == "model" ? "model_desc" : "model";
            ViewBag.UnitPriceSort = sort == "unitprice" ? "unitprice_desc" : "unitprice";

            ViewBag.CurrentSearch = search;

            IQueryable<Bike> bikeItems =  _context.Bikes.Include(b => b.Category);
                

            if (!String.IsNullOrEmpty(search))
                bikeItems = bikeItems.Where(bi => bi.Model.StartsWith(search) || bi.Model.Contains(search));

            switch(sort)
            {
                case "category_desc":
                    bikeItems = bikeItems.OrderByDescending(bi => bi.Category.CategoryName)
                        .ThenBy(bi => bi.Model);
                    break;
                case "model":
                    bikeItems = bikeItems.OrderBy(bi => bi.Model)
                        .ThenBy(bi => bi.Category.CategoryName);
                    break;
                case "model_desc":
                    bikeItems = bikeItems.OrderByDescending(bi => bi.Model)
                        .ThenBy(bi => bi.Category.CategoryName);
                    break;
                case "unitprice":
                    bikeItems = bikeItems.OrderBy(bi => bi.Price)
                        .ThenBy(bi => bi.Category.CategoryName);
                    break;
                case "unitprice_desc":
                    bikeItems = bikeItems.OrderByDescending(bi => bi.Price)
                        .ThenBy(bi => bi.Category.CategoryName);
                    break;

                default:
                    bikeItems = bikeItems.OrderBy(bi => bi.Category.CategoryName)
                        .ThenBy(bi => bi.Model);
                    break;

            }
            AdminListViewModel bikeList = new AdminListViewModel
            {
                Bikes = bikeItems.Skip((page - 1) * pageSize).Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = _context.Bikes.Count()
                }
            };
            return View(bikeList);
        }



        // GET: Admin/Create
        public IActionResult Create()
        {
            ViewBag.Category = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            return View();
        }

        //public ViewResult Create() => View("Edit", new Bike());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AdminCreateViewModel model)
        {
            Bike bike = new Bike {
                 CategoryId = model.Bike.CategoryId,
                 ImageThumbnailUrl = model.Bike.ImageThumbnailUrl,
                 ImageUrl = model.Bike.ImageUrl,
                 InStock = model.Bike.InStock,
                 IsBikeOfTheWeek = model.Bike.IsBikeOfTheWeek,
                 LongDescription = model.Bike.LongDescription,
                 ShortDescription = model.Bike.ShortDescription,
                 Price = model.Bike.Price,
                 Model = model.Bike.Model,
                 Category = _context.Categories.FirstOrDefault(c => c.CategoryId == model.Bike.CategoryId),
                 Specifications = new Specification
                 {
                     Bell = model.Specification.Bell,
                     BrakeDiscs = model.Specification.BrakeDiscs,
                     Brakes = model.Specification.Brakes,
                     Cassette = model.Specification.Cassette,
                     Chain = model.Specification.Chain,
                     Color = model.Specification.Color,
                     Crank = model.Specification.Crank,
                     Derailleur = model.Specification.Derailleur,
                     Fork = model.Specification.Fork,
                     Frame = model.Specification.Frame,
                     FrameSize = model.Specification.FrameSize,
                     FrontHub = model.Specification.FrontHub,
                     Grips = model.Specification.Grips,
                     Handlebar = model.Specification.Handlebar,
                     Headlight = model.Specification.Headlight,
                     Headset = model.Specification.Headset,
                     InnerBearing = model.Specification.InnerBearing,
                     Pedals = model.Specification.Pedals,
                     RearDerailleur = model.Specification.RearDerailleur,
                     RearHub = model.Specification.RearHub,
                     RearLight = model.Specification.RearLight,
                     RearRack = model.Specification.RearRack,
                     RearSuspension = model.Specification.RearSuspension,
                     Rims = model.Specification.Rims,
                     Saddle = model.Specification.Saddle,
                     Seatpost = model.Specification.Seatpost,
                     Shifter = model.Specification.Shifter,
                     Splashguard = model.Specification.Splashguard,
                     Spokes = model.Specification.Spokes,
                     Stand = model.Specification.Stand,
                     Steam = model.Specification.Steam,
                     Tires = model.Specification.Tires,
                     TravelFork = model.Specification.TravelFork,
                     TravelRearSuspension = model.Specification.TravelRearSuspension,
                     Weight = model.Specification.Weight,
                     Wheelset = model.Specification.Wheelset
                 }
            }; 
            
            if (ModelState.IsValid)
            {
                 
                _context.Add(bike);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Category = new SelectList(_context.Categories, "CategoryId", "CategoryName", model.Bike.CategoryId);
            return View(model);
        }


        public async Task<IActionResult> Edit(int? bikeId)
        {
            if (bikeId == null)
            {
                return NotFound();
            }

            var bike = await _context.Bikes.SingleOrDefaultAsync(m => m.BikeId == bikeId);
            if (bike == null)
            {
                return NotFound();
            }
            ViewBag.Category = new SelectList(_context.Categories, "CategoryId", "CategoryName", bike.CategoryId);
            return View(bike);
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int bikeId, [Bind("BikeId,Model,ShortDescription,LongDescription,Price,ImageUrl,ImageThumbnailUrl,IsBikeOfTheWeek,InStock,CategoryId")] Bike bike)
        {
            if (bikeId != bike.BikeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bike);
                    await _context.SaveChangesAsync();
                    TempData["message"] = $"{bike.Model} has been saved";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BikeExists(bike.BikeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewBag.Category = new SelectList(_context.Categories, "CategoryId", "CategoryName", bike.CategoryId);
            return View(bike);
        }
        public async Task<IActionResult> EditSpecification(int? bikeId)
        {
            if (bikeId == null)
            {
                return NotFound();
            }

            var specification = await _context.Specifications.SingleOrDefaultAsync(m => m.BikeId == bikeId);
            if (specification == null)
            {
                return NotFound();
            }

            return View(specification);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditSpecification(int bikeId, Specification specification)
        {
            if (bikeId != specification.BikeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(specification);
                    await _context.SaveChangesAsync();
                    TempData["message"] = $"{specification.Bike.Model} has been saved";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpecificationExists(specification.BikeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            
            return View(specification);
        }

        public async Task<IActionResult> Delete(int? bikeId)
        {
            if (bikeId == null)
            {
                return NotFound();
            }

            var bike = await _context.Bikes
                .Include(b => b.Category)
                .SingleOrDefaultAsync(m => m.BikeId == bikeId);
            if (bike == null)
            {
                return NotFound();
            }

            return View(bike);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int bikeId)
        {
            var bike = await _context.Bikes.SingleOrDefaultAsync(m => m.BikeId == bikeId);
            _context.Bikes.Remove(bike);
            await _context.SaveChangesAsync();
            TempData["message"] = $"{bike.Model} has been deleted";
            return RedirectToAction(nameof(Index));
        }

        private bool BikeExists(int id)
        {
            return _context.Bikes.Any(e => e.BikeId == id);
        }
        private bool SpecificationExists(int id)
        {
            return _context.Specifications.Any(e => e.BikeId == id);
        }
    }
}
