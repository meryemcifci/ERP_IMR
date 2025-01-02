using ERP_IMR.Models;
using ERP_IMR.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ERP_IMR.Controllers
{
    public class MATController : Controller
    {
        private readonly IMRDbContext _context;

        public MATController(IMRDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            // Yeni bir MalzemeViewModel nesnesi ile formu açıyoruz
            return View("~/Views/Main/MATCreat.cshtml", new MalzemeViewModel());
        }

        [HttpPost]
        public IActionResult Create(MalzemeViewModel model)
        {
            if (ModelState.IsValid)
            {
                // head tablosuna ekleme
                var newHead = new BSMIMRMATHEAD
                {
                    COMCODE = model.COMCODE,
                    MATDOCTYPE = model.MATDOCTYPE,
                    MATDOCNUM = model.MATDOCNUM,
                    MATDOCFROM = model.MATDOCFROM,
                    MATDOCUNTIL = model.MATDOCUNTIL,
                    SUPPLYTYPE = model.SUPPLYTYPE,
                    ISBOM = model.ISBOM,
                    ISROUTE = model.ISROUTE,
                    STUNIT = model.STUNIT,
                    NETWEIGHT = model.NETWEIGHT,
                    NWUNIT = model.NWUNIT,
                    BRUTWEIGHT = model.BRUTWEIGHT,
                    BWUNIT = model.BWUNIT,
                    BOMDOCTYPE = model.BOMDOCTYPE,
                    BOMDOCNUM = model.BOMDOCNUM,
                    ROTDOCTYPE = model.ROTDOCTYPE,
                    ROTDOCNUM = model.ROTDOCNUM,
                };

                // text tablosuna ekleme
                var newText = new BSMIMRMATTEXT
                {
                    LANCODE = model.LANCODE,
                    MATSTEXT = model.MATSTEXT,
                    MATLTEXT = model.MATLTEXT
                };

                _context.BSMIMRMATHEAD.Add(newHead);
                _context.BSMIMRMATTEXT.Add(newText);
                _context.SaveChanges();

                return RedirectToAction("MATGetJoinedData", "Main");
            }

            return View("~/Views/Main/MATCreat.cshtml", model); // Model hatalıysa tekrar forma dön
        }
    }
}
