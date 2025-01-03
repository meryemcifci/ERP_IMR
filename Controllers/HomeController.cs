 using ERP_IMR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ERP_IMR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        //public IActionResult Search(string query)
        //{
        //    if (string.IsNullOrWhiteSpace(query))
        //    {
        //        return RedirectToAction("Index");
        //    }

        //    // Arama işlemini gerçekleştirin (veritabanı sorgusu vs.)
        //    var results = _context.Items
        //        .Where(i => i.Name.Contains(query))
        //        .ToList();

        //    return View(results); // Arama sonuçlarını bir View'e gönderin
        //}

    }
}
