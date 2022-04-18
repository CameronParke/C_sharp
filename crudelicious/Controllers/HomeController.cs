using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using crudelicious.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace crudelicious.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.AllDishes = _context.Dishes.OrderByDescending(d => d.CreatedAt).ToList();
            return View();
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            ViewBag.AllDishes = _context.Dishes.OrderByDescending(d => d.Name).ToList();
            return View();
        }

        [HttpPost("create")]
        public IActionResult CreateDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else{
                ViewBag.AllDishes = _context.Dishes.OrderByDescending(d => d.Name).ToList();
                return View("new");
            }
        }

        [HttpGet("edit/{dishId}")]
        public IActionResult Edit(int dishId)
        {
            Dish DishToUpdate = _context.Dishes.FirstOrDefault(d => d.DishId == dishId);
            return View(DishToUpdate);
        }

        [HttpPost("update/{dishId}")]
        public IActionResult UpdateDish(int dishId, Dish updatedDish)
        {
            if(ModelState.IsValid)
            {
                Dish OldDish = _context.Dishes.FirstOrDefault(d => d.DishId == dishId);
                OldDish.Chef = updatedDish.Chef;
                OldDish.Name = updatedDish.Name;
                OldDish.Calories = updatedDish.Calories;
                OldDish.Tastiness = updatedDish.Tastiness;
                OldDish.Description = updatedDish.Description;
                OldDish.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("Show", new {dishId = dishId});
            } else{
                return View("Edit", updatedDish);
            }
        }

        [HttpGet("{dishId}")]
        public IActionResult Show(int dishId)
        {
            ViewBag.OneDish = _context.Dishes.Where(d => d.DishId == dishId).ToList();
            return View("Show");
        }

        [HttpGet("remove/{dishId}")]
        public IActionResult RemoveDish(int dishId)
        {
            Dish DishToRemove = _context.Dishes.FirstOrDefault(s => s.DishId == dishId);
            _context.Dishes.Remove(DishToRemove);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
