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
    public class BSMIMROPR001Controller : Controller
    {
        private readonly IMRDbContext _context;

        public BSMIMROPR001Controller(IMRDbContext context)
        {
            _context = context;
        }

        // GET: BSMIMROPR001
        public async Task<IActionResult> Index()
        {
              return _context.BSMIMROPR001 != null ? 
                          View(await _context.BSMIMROPR001.ToListAsync()) :
                          Problem("Entity set 'IMRDbContext.BSMIMROPR001'  is null.");
        }

        // GET: BSMIMROPR001/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BSMIMROPR001 == null)
            {
                return NotFound();
            }

            var bSMIMROPR001 = await _context.BSMIMROPR001
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMIMROPR001 == null)
            {
                return NotFound();
            }

            return View(bSMIMROPR001);
        }

        // GET: BSMIMROPR001/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BSMIMROPR001/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DOCTYPE,COMCODE,DOCTYPETEXT,ISPASSIVE")] BSMIMROPR001 bSMIMROPR001)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMIMROPR001);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bSMIMROPR001);
        }

        // GET: BSMIMROPR001/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BSMIMROPR001 == null)
            {
                return NotFound();
            }

            var bSMIMROPR001 = await _context.BSMIMROPR001.FindAsync(id);
            if (bSMIMROPR001 == null)
            {
                return NotFound();
            }
            return View(bSMIMROPR001);
        }

        // POST: BSMIMROPR001/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DOCTYPE,COMCODE,DOCTYPETEXT,ISPASSIVE")] BSMIMROPR001 bSMIMROPR001)
        {
            if (id != bSMIMROPR001.DOCTYPE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMIMROPR001);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMIMROPR001Exists(bSMIMROPR001.DOCTYPE))
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
            return View(bSMIMROPR001);
        }

        // GET: BSMIMROPR001/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BSMIMROPR001 == null)
            {
                return NotFound();
            }

            var bSMIMROPR001 = await _context.BSMIMROPR001
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMIMROPR001 == null)
            {
                return NotFound();
            }

            return View(bSMIMROPR001);
        }

        // POST: BSMIMROPR001/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BSMIMROPR001 == null)
            {
                return Problem("Entity set 'IMRDbContext.BSMIMROPR001'  is null.");
            }
            var bSMIMROPR001 = await _context.BSMIMROPR001.FindAsync(id);
            if (bSMIMROPR001 != null)
            {
                _context.BSMIMROPR001.Remove(bSMIMROPR001);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMIMROPR001Exists(string id)
        {
          return (_context.BSMIMROPR001?.Any(e => e.DOCTYPE == id)).GetValueOrDefault();
        }
    }
}
