using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using J4.Models;

namespace J4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Announcements()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
         public IActionResult Contests()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
         public IActionResult FAQ()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
         public IActionResult Feedback()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Recipes()
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
