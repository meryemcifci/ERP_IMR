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
    public class BSMIMRWCMHEADTEXTOPRController : Controller
    {
        private readonly IMRDbContext _context;

        public BSMIMRWCMHEADTEXTOPRController(IMRDbContext context)
        {
            _context = context;
        }

        // GET: BSMIMRWCMHEADTEXTOPR
        public async Task<IActionResult> Index()
        {
              return _context.BSMIMRWCMHEADTEXTOPR != null ? 
                          View(await _context.BSMIMRWCMHEADTEXTOPR.ToListAsync()) :
                          Problem("Entity set 'IMRDbContext.BSMIMRWCMHEADTEXTOPR'  is null.");
        }

        // GET: BSMIMRWCMHEADTEXTOPR/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BSMIMRWCMHEADTEXTOPR == null)
            {
                return NotFound();
            }

            var bSMIMRWCMHEADTEXTOPR = await _context.BSMIMRWCMHEADTEXTOPR
                .FirstOrDefaultAsync(m => m.WCMDOCNUM == id);
            if (bSMIMRWCMHEADTEXTOPR == null)
            {
                return NotFound();
            }

            return View(bSMIMRWCMHEADTEXTOPR);
        }

        // GET: BSMIMRWCMHEADTEXTOPR/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BSMIMRWCMHEADTEXTOPR/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("COMCODE,WCMDOCTYPE,WCMDOCNUM,WCMDOCFROM,WCMDOCUNTIL,MAINWCMDOCTYPE,MAINWCMDOCNUM,CCMDOCTYPE,CCMDOCNUM,WORKTIME,ISDELETED,ISPASSIVE,LANCODE,WCMSTEXT,WCMLTEXT,OPRDOCTYPE")] BSMIMRWCMHEADTEXTOPR bSMIMRWCMHEADTEXTOPR)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMIMRWCMHEADTEXTOPR);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bSMIMRWCMHEADTEXTOPR);
        }

        // GET: BSMIMRWCMHEADTEXTOPR/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BSMIMRWCMHEADTEXTOPR == null)
            {
                return NotFound();
            }

            var bSMIMRWCMHEADTEXTOPR = await _context.BSMIMRWCMHEADTEXTOPR.FindAsync(id);
            if (bSMIMRWCMHEADTEXTOPR == null)
            {
                return NotFound();
            }
            return View(bSMIMRWCMHEADTEXTOPR);
        }

        // POST: BSMIMRWCMHEADTEXTOPR/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("COMCODE,WCMDOCTYPE,WCMDOCNUM,WCMDOCFROM,WCMDOCUNTIL,MAINWCMDOCTYPE,MAINWCMDOCNUM,CCMDOCTYPE,CCMDOCNUM,WORKTIME,ISDELETED,ISPASSIVE,LANCODE,WCMSTEXT,WCMLTEXT,OPRDOCTYPE")] BSMIMRWCMHEADTEXTOPR bSMIMRWCMHEADTEXTOPR)
        {
            if (id != bSMIMRWCMHEADTEXTOPR.WCMDOCNUM)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMIMRWCMHEADTEXTOPR);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMIMRWCMHEADTEXTOPRExists(bSMIMRWCMHEADTEXTOPR.WCMDOCNUM))
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
            return View(bSMIMRWCMHEADTEXTOPR);
        }

        // GET: BSMIMRWCMHEADTEXTOPR/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BSMIMRWCMHEADTEXTOPR == null)
            {
                return NotFound();
            }

            var bSMIMRWCMHEADTEXTOPR = await _context.BSMIMRWCMHEADTEXTOPR
                .FirstOrDefaultAsync(m => m.WCMDOCNUM == id);
            if (bSMIMRWCMHEADTEXTOPR == null)
            {
                return NotFound();
            }

            return View(bSMIMRWCMHEADTEXTOPR);
        }

        // POST: BSMIMRWCMHEADTEXTOPR/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BSMIMRWCMHEADTEXTOPR == null)
            {
                return Problem("Entity set 'IMRDbContext.BSMIMRWCMHEADTEXTOPR'  is null.");
            }
            var bSMIMRWCMHEADTEXTOPR = await _context.BSMIMRWCMHEADTEXTOPR.FindAsync(id);
            if (bSMIMRWCMHEADTEXTOPR != null)
            {
                _context.BSMIMRWCMHEADTEXTOPR.Remove(bSMIMRWCMHEADTEXTOPR);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMIMRWCMHEADTEXTOPRExists(string id)
        {
          return (_context.BSMIMRWCMHEADTEXTOPR?.Any(e => e.WCMDOCNUM == id)).GetValueOrDefault();
        }
    }
}
