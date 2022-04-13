using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomPasscodeGenerator.Models;
using Microsoft.AspNetCore.Http;
using System.Text.Json;


namespace RandomPasscodeGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            string chars = "QWERTYUIOPASDFGHJKLZXCVBNM1234567890";
            Random rand = new Random();
            string Passcode = "";
            for(int i = 0; i <= 13; i++)
            {
                Passcode += chars[rand.Next(chars.Length)];
            }
            
            ViewBag.Passcode = Passcode;

            if(HttpContext.Session.GetInt32("count") == null)
            {
                HttpContext.Session.SetInt32("count", 0);
            }

            int? count = HttpContext.Session.GetInt32("count");
            count ++;
            HttpContext.Session.SetInt32("count", (int)count);
            ViewBag.Count = HttpContext.Session.GetInt32("count");
            return View();
        }

        // [HttpGet("generate")]
        // public IActionResult Generate()
        // {
        //     Random rand = new Random();
        //     HttpContext.Session.SetString("Passcode", Passcode[rand.Next(0, chars.Count)]);
        //     return RedirectToAction("Index");
        // }
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

    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            string value = session.GetString(key);
            // int value = session.GetInt32(key); // This is how it would look for getting an int value
            return value == null ? default(T) : JsonSerializer.Deserialize<T>(value);
        }
    }
}
