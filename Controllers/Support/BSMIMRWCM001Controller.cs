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
    public class BSMIMRWCM001Controller : Controller
    {
        private readonly IMRDbContext _context;

        public BSMIMRWCM001Controller(IMRDbContext context)
        {
            _context = context;
        }

        // GET: BSMIMRWCM001
        public async Task<IActionResult> Index()
        {
              return _context.BSMIMRWCM001 != null ? 
                          View(await _context.BSMIMRWCM001.ToListAsync()) :
                          Problem("Entity set 'IMRDbContext.BSMIMRWCM001'  is null.");
        }

        // GET: BSMIMRWCM001/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BSMIMRWCM001 == null)
            {
                return NotFound();
            }

            var bSMIMRWCM001 = await _context.BSMIMRWCM001
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMIMRWCM001 == null)
            {
                return NotFound();
            }

            return View(bSMIMRWCM001);
        }

        // GET: BSMIMRWCM001/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BSMIMRWCM001/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DOCTYPE,COMCODE,DOCTYPETEXT,ISPASSIVE")] BSMIMRWCM001 bSMIMRWCM001)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMIMRWCM001);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bSMIMRWCM001);
        }

        // GET: BSMIMRWCM001/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BSMIMRWCM001 == null)
            {
                return NotFound();
            }

            var bSMIMRWCM001 = await _context.BSMIMRWCM001.FindAsync(id);
            if (bSMIMRWCM001 == null)
            {
                return NotFound();
            }
            return View(bSMIMRWCM001);
        }

        // POST: BSMIMRWCM001/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DOCTYPE,COMCODE,DOCTYPETEXT,ISPASSIVE")] BSMIMRWCM001 bSMIMRWCM001)
        {
            if (id != bSMIMRWCM001.DOCTYPE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMIMRWCM001);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMIMRWCM001Exists(bSMIMRWCM001.DOCTYPE))
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
            return View(bSMIMRWCM001);
        }

        // GET: BSMIMRWCM001/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BSMIMRWCM001 == null)
            {
                return NotFound();
            }

            var bSMIMRWCM001 = await _context.BSMIMRWCM001
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMIMRWCM001 == null)
            {
                return NotFound();
            }

            return View(bSMIMRWCM001);
        }

        // POST: BSMIMRWCM001/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BSMIMRWCM001 == null)
            {
                return Problem("Entity set 'IMRDbContext.BSMIMRWCM001'  is null.");
            }
            var bSMIMRWCM001 = await _context.BSMIMRWCM001.FindAsync(id);
            if (bSMIMRWCM001 != null)
            {
                _context.BSMIMRWCM001.Remove(bSMIMRWCM001);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMIMRWCM001Exists(string id)
        {
          return (_context.BSMIMRWCM001?.Any(e => e.DOCTYPE == id)).GetValueOrDefault();
        }
    }
}
