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
    public class BSMIMRGEN004Controller : Controller
    {
        private readonly IMRDbContext _context;

        public BSMIMRGEN004Controller(IMRDbContext context)
        {
            _context = context;
        }

        // GET: BSMIMRGEN004
        public async Task<IActionResult> Index()
        {
              return _context.BSMIMRGEN004 != null ? 
                          View(await _context.BSMIMRGEN004.ToListAsync()) :
                          Problem("Entity set 'IMRDbContext.BSMIMRGEN004'  is null.");
        }

        // GET: BSMIMRGEN004/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BSMIMRGEN004 == null)
            {
                return NotFound();
            }

            var bSMIMRGEN004 = await _context.BSMIMRGEN004
                .FirstOrDefaultAsync(m => m.CITYCODE == id);
            if (bSMIMRGEN004 == null)
            {
                return NotFound();
            }

            return View(bSMIMRGEN004);
        }

        // GET: BSMIMRGEN004/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BSMIMRGEN004/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CITYCODE,COMCODE,CITYTEXT,COUNTRYCODE")] BSMIMRGEN004 bSMIMRGEN004)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMIMRGEN004);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bSMIMRGEN004);
        }

        // GET: BSMIMRGEN004/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BSMIMRGEN004 == null)
            {
                return NotFound();
            }

            var bSMIMRGEN004 = await _context.BSMIMRGEN004.FindAsync(id);
            if (bSMIMRGEN004 == null)
            {
                return NotFound();
            }
            return View(bSMIMRGEN004);
        }

        // POST: BSMIMRGEN004/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CITYCODE,COMCODE,CITYTEXT,COUNTRYCODE")] BSMIMRGEN004 bSMIMRGEN004)
        {
            if (id != bSMIMRGEN004.CITYCODE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMIMRGEN004);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMIMRGEN004Exists(bSMIMRGEN004.CITYCODE))
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
            return View(bSMIMRGEN004);
        }

        // GET: BSMIMRGEN004/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BSMIMRGEN004 == null)
            {
                return NotFound();
            }

            var bSMIMRGEN004 = await _context.BSMIMRGEN004
                .FirstOrDefaultAsync(m => m.CITYCODE == id);
            if (bSMIMRGEN004 == null)
            {
                return NotFound();
            }

            return View(bSMIMRGEN004);
        }

        // POST: BSMIMRGEN004/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BSMIMRGEN004 == null)
            {
                return Problem("Entity set 'IMRDbContext.BSMIMRGEN004'  is null.");
            }
            var bSMIMRGEN004 = await _context.BSMIMRGEN004.FindAsync(id);
            if (bSMIMRGEN004 != null)
            {
                _context.BSMIMRGEN004.Remove(bSMIMRGEN004);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMIMRGEN004Exists(string id)
        {
          return (_context.BSMIMRGEN004?.Any(e => e.CITYCODE == id)).GetValueOrDefault();
        }
    }
}
