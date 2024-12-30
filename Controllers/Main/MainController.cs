using Microsoft.AspNetCore.Mvc;

namespace ERP_IMR.Controllers.Main
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
