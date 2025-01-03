using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP_IMR.Models;
using ERP_IMR.Models.Deneme;

namespace ERP_IMR.Controllers.Deneme
{
    public class BSMIMRROTHEADCONTENTController : Controller
    {
        private readonly IMRDbContext _context;

        public BSMIMRROTHEADCONTENTController(IMRDbContext context)
        {
            _context = context;
        }

        // GET: BSMIMRROTHEADCONTENT
        public async Task<IActionResult> Index()
        {
              return _context.BSMIMRROTHEADCONTENT != null ? 
                          View(await _context.BSMIMRROTHEADCONTENT.ToListAsync()) :
                          Problem("Entity set 'IMRDbContext.BSMIMRROTHEADCONTENT'  is null.");
        }

        // GET: BSMIMRROTHEADCONTENT/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BSMIMRROTHEADCONTENT == null)
            {
                return NotFound();
            }

            var bSMIMRROTHEADCONTENT = await _context.BSMIMRROTHEADCONTENT
                .FirstOrDefaultAsync(m => m.ROTDOCNUM == id);
            if (bSMIMRROTHEADCONTENT == null)
            {
                return NotFound();
            }

            return View(bSMIMRROTHEADCONTENT);
        }

        // GET: BSMIMRROTHEADCONTENT/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BSMIMRROTHEADCONTENT/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("COMCODE,ROTDOCTYPE,ROTDOCNUM,ROTDOCFROM,ROTDOCUNTIL,MATDOCTYPE,MATDOCNUM,QUANTITY,ISDELETED,ISPASSIVE,DRAWNUM,OPRNUM,BOMDOCTYPE,BOMDOCNUM,CONTENTNUM,COMPONENT,WCMDOCTYPE,WCMDOCNUM,OPRDOCTYPE,SETUPTIME,MACHINETIME,LABOURTIME")] BSMIMRROTHEADCONTENT bSMIMRROTHEADCONTENT)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMIMRROTHEADCONTENT);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bSMIMRROTHEADCONTENT);
        }

        // GET: BSMIMRROTHEADCONTENT/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BSMIMRROTHEADCONTENT == null)
            {
                return NotFound();
            }

            var bSMIMRROTHEADCONTENT = await _context.BSMIMRROTHEADCONTENT.FindAsync(id);
            if (bSMIMRROTHEADCONTENT == null)
            {
                return NotFound();
            }
            return View(bSMIMRROTHEADCONTENT);
        }

        // POST: BSMIMRROTHEADCONTENT/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("COMCODE,ROTDOCTYPE,ROTDOCNUM,ROTDOCFROM,ROTDOCUNTIL,MATDOCTYPE,MATDOCNUM,QUANTITY,ISDELETED,ISPASSIVE,DRAWNUM,OPRNUM,BOMDOCTYPE,BOMDOCNUM,CONTENTNUM,COMPONENT,WCMDOCTYPE,WCMDOCNUM,OPRDOCTYPE,SETUPTIME,MACHINETIME,LABOURTIME")] BSMIMRROTHEADCONTENT bSMIMRROTHEADCONTENT)
        {
            if (id != bSMIMRROTHEADCONTENT.ROTDOCNUM)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMIMRROTHEADCONTENT);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMIMRROTHEADCONTENTExists(bSMIMRROTHEADCONTENT.ROTDOCNUM))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bSMIMRROTHEADCONTENT);
        }

        // GET: BSMIMRROTHEADCONTENT/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BSMIMRROTHEADCONTENT == null)
            {
                return NotFound();
            }

            var bSMIMRROTHEADCONTENT = await _context.BSMIMRROTHEADCONTENT
                .FirstOrDefaultAsync(m => m.ROTDOCNUM == id);
            if (bSMIMRROTHEADCONTENT == null)
            {
                return NotFound();
            }

            return View(bSMIMRROTHEADCONTENT);
        }

        // POST: BSMIMRROTHEADCONTENT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BSMIMRROTHEADCONTENT == null)
            {
                return Problem("Entity set 'IMRDbContext.BSMIMRROTHEADCONTENT'  is null.");
            }
            var bSMIMRROTHEADCONTENT = await _context.BSMIMRROTHEADCONTENT.FindAsync(id);
            if (bSMIMRROTHEADCONTENT != null)
            {
                _context.BSMIMRROTHEADCONTENT.Remove(bSMIMRROTHEADCONTENT);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMIMRROTHEADCONTENTExists(string id)
        {
          return (_context.BSMIMRROTHEADCONTENT?.Any(e => e.ROTDOCNUM == id)).GetValueOrDefault();
        }
    }
}
