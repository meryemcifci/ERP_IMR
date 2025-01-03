using Microsoft.AspNetCore.Mvc;

namespace ERP_IMR.Controllers.Deneme
{
    public class DenemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BSMIMRMATHEADTEXT()
        {
            return View();
        }
    }
}
