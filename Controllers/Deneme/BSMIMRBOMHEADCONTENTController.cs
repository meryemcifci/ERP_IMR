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
    public class BSMIMRBOMHEADCONTENTController : Controller
    {
        private readonly IMRDbContext _context;

        public BSMIMRBOMHEADCONTENTController(IMRDbContext context)
        {
            _context = context;
        }

        // GET: BSMIMRBOMHEADCONTENT
        public async Task<IActionResult> Index()
        {
              return _context.BSMIMRBOMHEADCONTENT != null ? 
                          View(await _context.BSMIMRBOMHEADCONTENT.ToListAsync()) :
                          Problem("Entity set 'IMRDbContext.BSMIMRBOMHEADCONTENT'  is null.");
        }

        // GET: BSMIMRBOMHEADCONTENT/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BSMIMRBOMHEADCONTENT == null)
            {
                return NotFound();
            }

            var bSMIMRBOMHEADCONTENT = await _context.BSMIMRBOMHEADCONTENT
                .FirstOrDefaultAsync(m => m.BOMDOCNUM == id);
            if (bSMIMRBOMHEADCONTENT == null)
            {
                return NotFound();
            }

            return View(bSMIMRBOMHEADCONTENT);
        }

        // GET: BSMIMRBOMHEADCONTENT/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BSMIMRBOMHEADCONTENT/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("COMCODE,BOMDOCTYPE,BOMDOCNUM,BOMDOCFROM,BOMDOCUNTIL,MATDOCTYPE,MATDOCNUM,QUANTITY,ISDELETED,ISPASSIVE,DRAWNUM,CONTENTNUM,COMPONENT,COMPBOMDOCTYPE,COMPBOMDOCNUM")] BSMIMRBOMHEADCONTENT bSMIMRBOMHEADCONTENT)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMIMRBOMHEADCONTENT);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bSMIMRBOMHEADCONTENT);
        }

        // GET: BSMIMRBOMHEADCONTENT/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BSMIMRBOMHEADCONTENT == null)
            {
                return NotFound();
            }

            var bSMIMRBOMHEADCONTENT = await _context.BSMIMRBOMHEADCONTENT.FindAsync(id);
            if (bSMIMRBOMHEADCONTENT == null)
            {
                return NotFound();
            }
            return View(bSMIMRBOMHEADCONTENT);
        }

        // POST: BSMIMRBOMHEADCONTENT/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("COMCODE,BOMDOCTYPE,BOMDOCNUM,BOMDOCFROM,BOMDOCUNTIL,MATDOCTYPE,MATDOCNUM,QUANTITY,ISDELETED,ISPASSIVE,DRAWNUM,CONTENTNUM,COMPONENT,COMPBOMDOCTYPE,COMPBOMDOCNUM")] BSMIMRBOMHEADCONTENT bSMIMRBOMHEADCONTENT)
        {
            if (id != bSMIMRBOMHEADCONTENT.BOMDOCNUM)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMIMRBOMHEADCONTENT);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMIMRBOMHEADCONTENTExists(bSMIMRBOMHEADCONTENT.BOMDOCNUM))
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
            return View(bSMIMRBOMHEADCONTENT);
        }

        // GET: BSMIMRBOMHEADCONTENT/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BSMIMRBOMHEADCONTENT == null)
            {
                return NotFound();
            }

            var bSMIMRBOMHEADCONTENT = await _context.BSMIMRBOMHEADCONTENT
                .FirstOrDefaultAsync(m => m.BOMDOCNUM == id);
            if (bSMIMRBOMHEADCONTENT == null)
            {
                return NotFound();
            }

            return View(bSMIMRBOMHEADCONTENT);
        }

        // POST: BSMIMRBOMHEADCONTENT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BSMIMRBOMHEADCONTENT == null)
            {
                return Problem("Entity set 'IMRDbContext.BSMIMRBOMHEADCONTENT'  is null.");
            }
            var bSMIMRBOMHEADCONTENT = await _context.BSMIMRBOMHEADCONTENT.FindAsync(id);
            if (bSMIMRBOMHEADCONTENT != null)
            {
                _context.BSMIMRBOMHEADCONTENT.Remove(bSMIMRBOMHEADCONTENT);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMIMRBOMHEADCONTENTExists(string id)
        {
          return (_context.BSMIMRBOMHEADCONTENT?.Any(e => e.BOMDOCNUM == id)).GetValueOrDefault();
        }
    }
}
