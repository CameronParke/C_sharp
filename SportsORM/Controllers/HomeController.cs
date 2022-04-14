using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues.Where(l => l.Sport.Contains("Baseball")).ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.WomensLeagues = _context.Leagues.Where(l => l.Name.Contains("Womens'")).ToList();
            ViewBag.AnyHockey = _context.Leagues.Where(l => l.Sport.Contains("Hockey")).ToList();
            ViewBag.NoFootball = _context.Leagues.Where(l => l.Sport != "Football").ToList();
            ViewBag.Conferences = _context.Leagues.Where(l => l.Name.Contains("Conference")).ToList();
            ViewBag.Atlantics = _context.Leagues.Where(l => l.Name.Contains("Atlantic")).ToList();
            ViewBag.Dallas = _context.Teams.Where(l => l.Location == "Dallas").ToList();
            ViewBag.Raptors = _context.Teams.Where(l => l.TeamName == "Raptors").ToList();
            ViewBag.City = _context.Teams.Where(l => l.Location.Contains("City")).ToList();
            ViewBag.TeeStart = _context.Teams.ToList().Where(l => l.TeamName[0] == 'T');
            ViewBag.SortLoc = _context.Teams.OrderBy(l => l.Location).ToList();
            ViewBag.ReverseTeam = _context.Teams.OrderByDescending(l => l.TeamName).ToList();
            ViewBag.Cooper = _context.Players.Where(l => l.LastName == "Cooper").ToList();
            ViewBag.Joshua = _context.Players.Where(l => l.FirstName == "Joshua").ToList();
            ViewBag.NoJoshua = _context.Players.Where(l => l.LastName == "Cooper" && l.FirstName != "Joshua").ToList();
            ViewBag.AlexOrWyatt = _context.Players.Where(l => l.FirstName == "Alexander" || l.FirstName == "Wyatt").ToList();
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}