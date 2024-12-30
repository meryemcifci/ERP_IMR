using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP_IMR.Models;

namespace ERP_IMR.Controllers.Support
{
    public class BSMIMRCCM001Controller : Controller
    {
        private readonly IMRDbContext _context;

        public BSMIMRCCM001Controller(IMRDbContext context)
        {
            _context = context;
        }

        // GET: BSMIMRCCM001
        public async Task<IActionResult> Index()
        {
              return _context.BSMIMRCCM001 != null ? 
                          View(await _context.BSMIMRCCM001.ToListAsync()) :
                          Problem("Entity set 'IMRDbContext.BSMIMRCCM001'  is null.");
        }

        // GET: BSMIMRCCM001/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BSMIMRCCM001 == null)
            {
                return NotFound();
            }

            var bSMIMRCCM001 = await _context.BSMIMRCCM001
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMIMRCCM001 == null)
            {
                return NotFound();
            }

            return View(bSMIMRCCM001);
        }

        // GET: BSMIMRCCM001/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BSMIMRCCM001/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DOCTYPE,COMCODE,DOCTYPETEXT,ISPASSIVE")] BSMIMRCCM001 bSMIMRCCM001)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMIMRCCM001);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bSMIMRCCM001);
        }

        // GET: BSMIMRCCM001/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BSMIMRCCM001 == null)
            {
                return NotFound();
            }

            var bSMIMRCCM001 = await _context.BSMIMRCCM001.FindAsync(id);
            if (bSMIMRCCM001 == null)
            {
                return NotFound();
            }
            return View(bSMIMRCCM001);
        }

        // POST: BSMIMRCCM001/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DOCTYPE,COMCODE,DOCTYPETEXT,ISPASSIVE")] BSMIMRCCM001 bSMIMRCCM001)
        {
            if (id != bSMIMRCCM001.DOCTYPE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMIMRCCM001);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMIMRCCM001Exists(bSMIMRCCM001.DOCTYPE))
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
            return View(bSMIMRCCM001);
        }

        // GET: BSMIMRCCM001/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BSMIMRCCM001 == null)
            {
                return NotFound();
            }

            var bSMIMRCCM001 = await _context.BSMIMRCCM001
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMIMRCCM001 == null)
            {
                return NotFound();
            }

            return View(bSMIMRCCM001);
        }

        // POST: BSMIMRCCM001/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BSMIMRCCM001 == null)
            {
                return Problem("Entity set 'IMRDbContext.BSMIMRCCM001'  is null.");
            }
            var bSMIMRCCM001 = await _context.BSMIMRCCM001.FindAsync(id);
            if (bSMIMRCCM001 != null)
            {
                _context.BSMIMRCCM001.Remove(bSMIMRCCM001);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMIMRCCM001Exists(string id)
        {
          return (_context.BSMIMRCCM001?.Any(e => e.DOCTYPE == id)).GetValueOrDefault();
        }
    }
}
