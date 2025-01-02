using ERP_IMR.Models;
using ERP_IMR.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ERP_IMR.Controllers.Main
{
    public class WCMController : Controller
    {
        private readonly IMRDbContext _context;

        public WCMController(IMRDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View("~/Views/Main/WCMCreate.cshtml", new İşMerkeziViewModel());
        }

        [HttpPost]
        public IActionResult Create(İşMerkeziViewModel model)
        {
            if (ModelState.IsValid)
            {
                // head tablosuna ekleme
                var newHead = new BSMIMRWCMHEAD
                {
                    COMCODE = model.COMCODE,
                    WCMDOCTYPE = model.WCMDOCTYPE,
                    WCMDOCNUM = model.WCMDOCNUM,
                    WCMDOCFROM = model.WCMDOCFROM,
                    WCMDOCUNTIL = model.WCMDOCUNTIL,
                    MAINWCMDOCTYPE = model.MAINWCMDOCTYPE,
                    MAINWCMDOCNUM = model.MAINWCMDOCNUM,
                    CCMDOCTYPE = model.CCMDOCTYPE,
                    CCMDOCNUM = model.CCMDOCNUM,
                    WORKTIME = model.WORKTIME,
                    ISDELETED = model.ISDELETED,
                    ISPASSIVE = model.ISPASSIVE,
                 
                };

                // text tablosuna ekleme
                var newText = new BSMIMRWCMTEXT
                {
                    WCMSTEXT = model.WCMSTEXT,
                };
                var newOpr = new BSMIMRWCMOPR
                {
                    OPRDOCTYPE = model.OPRDOCTYPE,
                };

                _context.BSMIMRWCMHEAD.Add(newHead);
                _context.BSMIMRWCMTEXT.Add(newText);
                _context.BSMIMRWCMOPR.Add(newOpr);
                _context.SaveChanges();

                return RedirectToAction("WCMGetJoinedData", "Main");
            }

            return View("~/Views/Main/WCMCreate.cshtml", model); // Model hatalıysa tekrar forma dön
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
