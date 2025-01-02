using Microsoft.AspNetCore.Mvc;

namespace ERP_IMR.Controllers.Main
{
    public class OPRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
