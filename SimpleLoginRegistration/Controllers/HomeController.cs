using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleLoginRegistration.Models;

namespace SimpleLoginRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult RegisterUser(IndexViewModel modelData)
        {
            RegUser registeredUser = modelData.NewUser;
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index");
        }

        [HttpPost("login")]
        public IActionResult LogInUser(IndexViewModel modelData)
        {
            LogUser loggedIn = modelData.NewLogIn;
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index");
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            return View("Success");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
