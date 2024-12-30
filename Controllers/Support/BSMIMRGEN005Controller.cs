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
    public class BSMIMRGEN005Controller : Controller
    {
        private readonly IMRDbContext _context;

        public BSMIMRGEN005Controller(IMRDbContext context)
        {
            _context = context;
        }

        // GET: BSMIMRGEN005
        public async Task<IActionResult> Index()
        {
              return _context.BSMIMRGEN005 != null ? 
                          View(await _context.BSMIMRGEN005.ToListAsync()) :
                          Problem("Entity set 'IMRDbContext.BSMIMRGEN005'  is null.");
        }

        // GET: BSMIMRGEN005/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BSMIMRGEN005 == null)
            {
                return NotFound();
            }

            var bSMIMRGEN005 = await _context.BSMIMRGEN005
                .FirstOrDefaultAsync(m => m.UNITCODE == id);
            if (bSMIMRGEN005 == null)
            {
                return NotFound();
            }

            return View(bSMIMRGEN005);
        }

        // GET: BSMIMRGEN005/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BSMIMRGEN005/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UNITCODE,COMCODE,UNITTEXT,ISMAINUNIT,MAINUNITCODE")] BSMIMRGEN005 bSMIMRGEN005)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMIMRGEN005);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bSMIMRGEN005);
        }

        // GET: BSMIMRGEN005/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BSMIMRGEN005 == null)
            {
                return NotFound();
            }

            var bSMIMRGEN005 = await _context.BSMIMRGEN005.FindAsync(id);
            if (bSMIMRGEN005 == null)
            {
                return NotFound();
            }
            return View(bSMIMRGEN005);
        }

        // POST: BSMIMRGEN005/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UNITCODE,COMCODE,UNITTEXT,ISMAINUNIT,MAINUNITCODE")] BSMIMRGEN005 bSMIMRGEN005)
        {
            if (id != bSMIMRGEN005.UNITCODE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMIMRGEN005);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMIMRGEN005Exists(bSMIMRGEN005.UNITCODE))
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
            return View(bSMIMRGEN005);
        }

        // GET: BSMIMRGEN005/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BSMIMRGEN005 == null)
            {
                return NotFound();
            }

            var bSMIMRGEN005 = await _context.BSMIMRGEN005
                .FirstOrDefaultAsync(m => m.UNITCODE == id);
            if (bSMIMRGEN005 == null)
            {
                return NotFound();
            }

            return View(bSMIMRGEN005);
        }

        // POST: BSMIMRGEN005/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BSMIMRGEN005 == null)
            {
                return Problem("Entity set 'IMRDbContext.BSMIMRGEN005'  is null.");
            }
            var bSMIMRGEN005 = await _context.BSMIMRGEN005.FindAsync(id);
            if (bSMIMRGEN005 != null)
            {
                _context.BSMIMRGEN005.Remove(bSMIMRGEN005);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMIMRGEN005Exists(string id)
        {
          return (_context.BSMIMRGEN005?.Any(e => e.UNITCODE == id)).GetValueOrDefault();
        }
    }
}
