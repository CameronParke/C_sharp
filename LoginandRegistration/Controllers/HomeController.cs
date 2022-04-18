using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginandRegistration.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LoginandRegistration.Controllers
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
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                // I want to verify that this email is the only email in our database
                if(_context.Users.Any(s => s.Email == newUser.Email))
                {
                    // This is a problem, the email is already in the database
                    // So we need to kick the person back with an error message
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                // I want to hash the password BEFORE I get into the Database, but AFTER I have verified I am a legit potential register
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", newUser.UserId);
                return RedirectToAction("Success");
            } else {
                return View("Index");
            }
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("loggingin")]
        public IActionResult LoggingIn(LoginUser loginUser)
        {
            //  How do I know this is a legit user logging in?
            if(ModelState.IsValid)
            {
                // Step one: find the user based on email
                User userInDb = _context.Users.FirstOrDefault(d => d.Email == loginUser.LogEmail);
                
                if(userInDb == null)
                {
                    ModelState.AddModelError("LogEmail", "Invalid Email/Password");
                    return View("Login");
                }
                // Step two: check the password against the password given
                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(loginUser, userInDb.Password, loginUser.LogPassword);
                if(result == 0)
                {
                    // Failure the password was incorrect
                    ModelState.AddModelError("LogEmail", "Invalid Email/Password");
                    return View("Login");
                }
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Success");
            } else {
                return View("Login");
            }
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            if(HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            User LoggedInUser = _context.Users.FirstOrDefault(a => a.UserId == (int) HttpContext.Session.GetInt32("UserId"));
            return View(LoggedInUser);
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
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
