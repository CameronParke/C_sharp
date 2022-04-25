using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers
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
            return View();
        }

        [HttpPost("user/create")]
        public IActionResult RegisterUser(User newUser)
        {
            if(ModelState.IsValid)  // validation check
            {
                if(_context.Users.Any(s => s.Email == newUser.Email))  // checking if email already exists in database
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", newUser.UserId); // set User in Session
                return RedirectToAction("Dashboard");
            } else {
                return View("Index");
            }
        }

        [HttpPost("user/login")]
        public IActionResult Login(LoginUser userLoggedIn)
        {
            if(ModelState.IsValid)  // validation check
            {
                User userInDb = _context.Users.FirstOrDefault(d => d.Email == userLoggedIn.LogEmail);
                
                if(userInDb == null) // if the User is not registered in the Database
                {
                    ModelState.AddModelError("LogEmail", "Invalid Email/Password");
                    return View ("Index");
                }

                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(userLoggedIn, userInDb.Password, userLoggedIn.LogPassword);
                if(result == 0) // checks the User logging in Hashed password against User in Database Hashed password
                {
                    ModelState.AddModelError("LogEmail", "Invalid Email/Password");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("UserId", userInDb.UserId); // set User in Session
                return RedirectToAction("Dashboard");
            } else {
                return View("Index");
            }
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard(int userId)
        {
            if(HttpContext.Session.GetInt32("UserId") == null)  // session check
            {
                return RedirectToAction("Index");
            }
            
            ViewBag.LoggedIn = _context.Users.FirstOrDefault(a => a.UserId == HttpContext.Session.GetInt32("UserId")); // get logged in user
            
            ViewBag.AllWeddings = _context.Weddings.OrderBy(d => d.Date).Include(p => p.Planner).Include(g => g.GuestList).ToList(); // get all the weddings, include Planner (User that created the Wedding) and Guestlist
            return View();
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            if(HttpContext.Session.GetInt32("UserId") == null)  // session check
            {
                return RedirectToAction("Index");
            }
            HttpContext.Session.Clear();  // clear User from Session
            return RedirectToAction("Index");
        }

        [HttpGet("add/wedding")]
        public IActionResult AddWedding()
        {
            if(HttpContext.Session.GetInt32("UserId") == null)  // session check
            {
                return RedirectToAction("Index");
            }
            return View("AddWedding");
        }

        [HttpPost("create/wedding")]
        public IActionResult CreateWedding(Wedding newWedding)
        {
            if(HttpContext.Session.GetInt32("UserId") == null)  // session check
            {
                return RedirectToAction("Index");
            }
            if(ModelState.IsValid)  // validation check
            {
                newWedding.UserId = (int)HttpContext.Session.GetInt32("UserId");
                _context.Weddings.Add(newWedding);
                _context.SaveChanges();
                return RedirectToAction("OneWedding", new {wedId = newWedding.WeddingId});
            } else {
                return View("AddWedding");

            }
        }

        [HttpGet("wedding/{wedId}")]
        public IActionResult OneWedding(int wedId)
        {
            if(HttpContext.Session.GetInt32("UserId") == null)  // session check
            {
                return RedirectToAction("Index");
            }

            Wedding oneWedding = _context.Weddings.FirstOrDefault(a => a.WeddingId == wedId);
            ViewBag.Wedding = oneWedding;

            List<Guest> Guests = _context.Guests.Where(a => a.WeddingId == wedId).Include(a => a.User).ToList();
            ViewBag.GuestList = Guests;
            return View("OneWedding");
        }

        [HttpGet("unrsvp/{wedId}")]
        public IActionResult UnRSVP(int wedId)
        {
            if(HttpContext.Session.GetInt32("UserId") == null)  // session check
            {
                return RedirectToAction("Index");
            }
            var Guest = _context.Guests.FirstOrDefault(b => b.UserId ==(int)HttpContext.Session.GetInt32("UserId") && b.WeddingId == wedId);
            _context.Guests.Remove(Guest);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        
        [HttpGet("rsvp/{wedId}")]
        public IActionResult RSVP(int wedId)
        {
            if(HttpContext.Session.GetInt32("UserId") == null)  // session check
            {
                return RedirectToAction("Index");
            }
            _context.Guests.Add(new Guest{UserId = (int)HttpContext.Session.GetInt32("UserId"), WeddingId = wedId});
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("wedding/delete/{wedId}")]
        public IActionResult DeleteWedding(int wedId)
        {
            if(HttpContext.Session.GetInt32("UserId") == null)  // session check
            {
                return RedirectToAction("Index");
            }
            var Wedding = _context.Weddings.FirstOrDefault(d => d.WeddingId == wedId);
            _context.Weddings.Remove(Wedding);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
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
