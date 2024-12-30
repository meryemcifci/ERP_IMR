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
    public class BSMIMRGEN003Controller : Controller
    {
        private readonly IMRDbContext _context;

        public BSMIMRGEN003Controller(IMRDbContext context)
        {
            _context = context;
        }

        // GET: BSMIMRGEN003
        public async Task<IActionResult> Index()
        {
              return _context.BSMIMRGEN003 != null ? 
                          View(await _context.BSMIMRGEN003.ToListAsync()) :
                          Problem("Entity set 'IMRDbContext.BSMIMRGEN003'  is null.");
        }

        // GET: BSMIMRGEN003/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BSMIMRGEN003 == null)
            {
                return NotFound();
            }

            var bSMIMRGEN003 = await _context.BSMIMRGEN003
                .FirstOrDefaultAsync(m => m.COUNTRYCODE == id);
            if (bSMIMRGEN003 == null)
            {
                return NotFound();
            }

            return View(bSMIMRGEN003);
        }

        // GET: BSMIMRGEN003/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BSMIMRGEN003/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("COUNTRYCODE,COMCODE,COUNTRYTEXT")] BSMIMRGEN003 bSMIMRGEN003)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMIMRGEN003);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bSMIMRGEN003);
        }

        // GET: BSMIMRGEN003/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BSMIMRGEN003 == null)
            {
                return NotFound();
            }

            var bSMIMRGEN003 = await _context.BSMIMRGEN003.FindAsync(id);
            if (bSMIMRGEN003 == null)
            {
                return NotFound();
            }
            return View(bSMIMRGEN003);
        }

        // POST: BSMIMRGEN003/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("COUNTRYCODE,COMCODE,COUNTRYTEXT")] BSMIMRGEN003 bSMIMRGEN003)
        {
            if (id != bSMIMRGEN003.COUNTRYCODE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMIMRGEN003);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMIMRGEN003Exists(bSMIMRGEN003.COUNTRYCODE))
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
            return View(bSMIMRGEN003);
        }

        // GET: BSMIMRGEN003/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BSMIMRGEN003 == null)
            {
                return NotFound();
            }

            var bSMIMRGEN003 = await _context.BSMIMRGEN003
                .FirstOrDefaultAsync(m => m.COUNTRYCODE == id);
            if (bSMIMRGEN003 == null)
            {
                return NotFound();
            }

            return View(bSMIMRGEN003);
        }

        // POST: BSMIMRGEN003/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BSMIMRGEN003 == null)
            {
                return Problem("Entity set 'IMRDbContext.BSMIMRGEN003'  is null.");
            }
            var bSMIMRGEN003 = await _context.BSMIMRGEN003.FindAsync(id);
            if (bSMIMRGEN003 != null)
            {
                _context.BSMIMRGEN003.Remove(bSMIMRGEN003);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMIMRGEN003Exists(string id)
        {
          return (_context.BSMIMRGEN003?.Any(e => e.COUNTRYCODE == id)).GetValueOrDefault();
        }
    }
}
