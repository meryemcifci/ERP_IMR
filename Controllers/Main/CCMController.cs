using ERP_IMR.Models;
using ERP_IMR.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ERP_IMR.Controllers
{
    public class CCMController : Controller

    {
        private readonly IMRDbContext _context;

        public CCMController(IMRDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            // Yeni bir MalzemeViewModel nesnesi ile formu açıyoruz
            return View("~/Views/Main/CCMCreatE.cshtml", new MaliyetViewModel());
        }

        [HttpPost]
        public IActionResult Create(MaliyetViewModel model)
        {
            if (ModelState.IsValid)
            {
                // head tablosuna ekleme
                var newHead = new BSMIMRCCMHEAD
                {
                    COMCODE = model.COMCODE,
                    CCMDOCTYPE = model.CCMDOCTYPE,
                    CCMDOCNUM = model.CCMDOCNUM,
                    CCMDOCFROM =model.CCMDOCFROM,
                    CCMDOCUNTIL =model.CCMDOCUNTIL,
                    MAINCCMDOCTYPE = model.MAINCCMDOCTYPE,
                    MAINCCMDOCNUM =model.MAINCCMDOCNUM,
                    ISDELETED =model.ISDELETED,
                    ISPASSIVE =model.ISPASSIVE,
                   
                };

                // text tablosuna ekleme
                var newText = new BSMIMRCCMTEXT
                {
                    CCMSTEXT = model.CCMSTEXT,
                   
                  
                };

                _context.BSMIMRCCMHEAD.Add(newHead);
                _context.BSMIMRCCMTEXT.Add(newText);
                _context.SaveChanges();

                return RedirectToAction("CCMGetJoinedData", "Main");
            }

            return View("~/Views/Main/CCMCreatE.cshtml", model); // Model hatalıysa tekrar forma dön
        }
    }
}

