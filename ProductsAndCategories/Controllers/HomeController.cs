using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsAndCategories.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductsAndCategories.Controllers
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

        public IActionResult Index()
        {
            ViewBag.AllProducts = _context.Products.OrderBy(a => a.Name).ToList();
            return View();
        }

        [HttpPost("product/add")]
        public IActionResult AddProduct(Product newProduct)
        {
            if(ModelState.IsValid)
            {
                _context.Products.Add(newProduct);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else {
                ViewBag.AllProducts = _context.Products.OrderBy(a => a.Name).ToList();
                return View("Index");
            }
        }

        [HttpGet("product/{prodId}")]
        public IActionResult OneProduct(int prodId)
        {
            ViewBag.OneProduct = _context.Products.Include(a => a.CategoryTypes).ThenInclude(b => b.Category).FirstOrDefault(c => c.ProductId == prodId);
            ViewBag.AllCategories = _context.Categories.OrderBy(a => a.CategoryName).ToList();
            return View();
        }

        [HttpPost("association/add")]
        public IActionResult AddAssociation(Association newAssociation, string option)
        {
            Console.WriteLine($"Your option is: {option}");
            _context.Associations.Add(newAssociation);
            _context.SaveChanges();
            if(option == "Product")
            {
                return Redirect($"/product/{newAssociation.ProductId}");
            } else {
                return Redirect($"/category/{newAssociation.CategoryId}");
            }
        }

        [HttpGet("categories")]
        public IActionResult Categories()
        {
            ViewBag.AllCategories = _context.Categories.OrderBy(a => a.CategoryName).ToList();
            return View();
        }

        [HttpPost("category/add")]
        public IActionResult AddCategory(Category newCategory)
        {
            if(ModelState.IsValid)
            {
                _context.Categories.Add(newCategory);
                _context.SaveChanges();
                return RedirectToAction("Categories");
            } else {
                ViewBag.AllCategories = _context.Categories.OrderBy(a => a.CategoryName).ToList();
                return View("Categories");
            }
        }

        [HttpGet("category/{catId}")]
        public IActionResult OneCategory(int catId)
        {
            ViewBag.OneCategory = _context.Categories.Include(a => a.ProductInventory).ThenInclude(b => b.Product).FirstOrDefault(c => c.CategoryId == catId);
            ViewBag.AllProducts = _context.Products.OrderBy(a => a.Name).ToList();
            return View();
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
