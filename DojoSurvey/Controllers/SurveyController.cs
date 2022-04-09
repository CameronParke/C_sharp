using System;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey
{
    public class SurveyController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult result(string name, string location, string language, string comment)
        {
            // Console.WriteLine($"Name: {name}");  
            // Console.WriteLine($"DojoLocation: {location}");
            // Console.WriteLine($"FavoriteLanguage: {language}");
            // Console.WriteLine($"Comment: {comment}");
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;
            return View("result");
        }
    }
}