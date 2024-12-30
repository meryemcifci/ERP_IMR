using Microsoft.AspNetCore.Mvc;

namespace ERP_IMR.Controllers.Support
{
    public class SupportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
