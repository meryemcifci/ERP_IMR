using ERP_IMR.Models;
using ERP_IMR.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Emit;

namespace ERP_IMR.Controllers.Main
{
    public class MainController : Controller
    {
        private readonly IMRDbContext _context;

        public MainController(IMRDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        //Malzeme Kartları
        public IActionResult MATGetJoinedData()
        {
            var joinedData = (from head in _context.BSMIMRMATHEAD
                              join text in _context.BSMIMRMATTEXT
                              on head.MATDOCNUM equals text.MATSTEXT
                              select new MalzemeViewModel
                              {
                                COMCODE=text.COMCODE,
                                MATDOCTYPE=text.MATDOCTYPE,
                                MATDOCNUM=text.MATDOCNUM,
                                MATDOCFROM=head.MATDOCFROM,
                                MATDOCUNTIL=head.MATDOCUNTIL,
                                LANCODE=text.LANCODE,
                                MATSTEXT=text.MATSTEXT,
                                MATLTEXT=text.MATLTEXT,
                                SUPPLYTYPE = head.SUPPLYTYPE,
                                ISBOM = head.ISBOM,
                                ISROUTE= head.ISROUTE,

                              }).ToList();

            return View(joinedData);
        }

        //[HttpGet]
        //public IActionResult Edit(string id)
        //{
        //    var itemHead = _context.BSMIMRMATHEAD.FirstOrDefault(x => x.MATDOCNUM == id);
        //    var itemText = _context.BSMIMRMATTEXT.FirstOrDefault(x => x.MATSTEXT == id);
        //    if (itemHead == null) return NotFound();

        //    var model = new MalzemeViewModel
        //    {
        //        COMCODE = itemHead.COMCODE,
        //        MATDOCTYPE = itemHead.MATDOCTYPE,
        //        MATDOCNUM = itemHead.MATDOCNUM,
        //        MATDOCFROM = itemHead.MATDOCFROM,
        //        MATDOCUNTIL = itemHead.MATDOCUNTIL,
        //        LANCODE = itemText.LANCODE,
        //        MATSTEXT = itemText.MATSTEXT,
        //        MATLTEXT = itemText.MATLTEXT,
        //        SUPPLYTYPE = itemHead.SUPPLYTYPE,
        //        ISBOM = itemHead.ISBOM,
        //        ISROUTE = itemHead.ISROUTE
        //    };

        //    return View(model);
        //}

  
        public IActionResult CCMGetJoinedData()
        {
            var joinedData = (from head in _context.BSMIMRCCMHEAD
                              join text in _context.BSMIMRCCMTEXT
                              on head.CCMDOCNUM equals text.CCMSTEXT
                              select new MaliyetViewModel
                              {
                                  COMCODE =head.COMCODE,
                                  CCMDOCTYPE = head.CCMDOCTYPE,
                                  CCMDOCNUM = head.CCMDOCNUM,
                                  CCMDOCFROM = head.CCMDOCFROM,
                                  CCMDOCUNTIL = head.CCMDOCUNTIL,
                                  MAINCCMDOCTYPE = head.MAINCCMDOCTYPE,
                                  MAINCCMDOCNUM = head.MAINCCMDOCNUM,
                                  ISDELETED = head.ISDELETED,
                                  ISPASSIVE = head.ISPASSIVE,
                                  CCMSTEXT = text.CCMSTEXT,

                              }).ToList();

            return View(joinedData);
        }
        public IActionResult WCMGetJoinedData()
        {
            var joinedData = (from head in _context.BSMIMRWCMHEAD
                               join text in _context.BSMIMRWCMTEXT
                                on head.WCMDOCNUM equals text.WCMSTEXT
                               join opr in _context.BSMIMRWCMOPR
                               on head.WCMDOCNUM equals opr.OPRDOCTYPE
                              select new İşMerkeziViewModel
                              {
                                  COMCODE = head.COMCODE,
                                  WCMDOCTYPE = head.WCMDOCTYPE,
                                  WCMDOCNUM = head.WCMDOCNUM,
                                  WCMDOCFROM = head.WCMDOCFROM,
                                  WCMDOCUNTIL = head.WCMDOCUNTIL,
                                  MAINWCMDOCTYPE = head.MAINWCMDOCTYPE,
                                  MAINWCMDOCNUM = head.MAINWCMDOCNUM,
                                  CCMDOCTYPE = head.CCMDOCTYPE,
                                  CCMDOCNUM = head.CCMDOCNUM,
                                  WORKTIME = head.WORKTIME,
                                  ISDELETED = head.ISDELETED,
                                  ISPASSIVE = head.ISPASSIVE,
                                  WCMSTEXT = text.WCMSTEXT,
                                  OPRDOCTYPE = opr.OPRDOCTYPE,

                              }).ToList();

            return View(joinedData);
        }
    }
}
