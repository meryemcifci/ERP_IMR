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
    public class BSMIMRGEN001Controller : Controller
    {
        private readonly IMRDbContext _context;

        public BSMIMRGEN001Controller(IMRDbContext context)
        {
            _context = context;
        }

        // GET: BSMIMRGEN001
        public async Task<IActionResult> Index()
        {
              return _context.BSMIMRGEN001 != null ? 
                          View(await _context.BSMIMRGEN001.ToListAsync()) :
                          Problem("Entity set 'IMRDbContext.BSMIMRGEN001'  is null.");
        }

        // GET: BSMIMRGEN001/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BSMIMRGEN001 == null)
            {
                return NotFound();
            }

            var bSMIMRGEN001 = await _context.BSMIMRGEN001
                .FirstOrDefaultAsync(m => m.COMCODE == id);
            if (bSMIMRGEN001 == null)
            {
                return NotFound();
            }

            return View(bSMIMRGEN001);
        }

        // GET: BSMIMRGEN001/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BSMIMRGEN001/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("COMCODE,COMTEXT,ADDRESS1,ADDRESS2,CITYCODE,COUNTRYCODE")] BSMIMRGEN001 bSMIMRGEN001)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMIMRGEN001);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bSMIMRGEN001);
        }

        // GET: BSMIMRGEN001/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BSMIMRGEN001 == null)
            {
                return NotFound();
            }

            var bSMIMRGEN001 = await _context.BSMIMRGEN001.FindAsync(id);
            if (bSMIMRGEN001 == null)
            {
                return NotFound();
            }
            return View(bSMIMRGEN001);
        }

        // POST: BSMIMRGEN001/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("COMCODE,COMTEXT,ADDRESS1,ADDRESS2,CITYCODE,COUNTRYCODE")] BSMIMRGEN001 bSMIMRGEN001)
        {
            if (id != bSMIMRGEN001.COMCODE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMIMRGEN001);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMIMRGEN001Exists(bSMIMRGEN001.COMCODE))
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
            return View(bSMIMRGEN001);
        }

        // GET: BSMIMRGEN001/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BSMIMRGEN001 == null)
            {
                return NotFound();
            }

            var bSMIMRGEN001 = await _context.BSMIMRGEN001
                .FirstOrDefaultAsync(m => m.COMCODE == id);
            if (bSMIMRGEN001 == null)
            {
                return NotFound();
            }

            return View(bSMIMRGEN001);
        }

        // POST: BSMIMRGEN001/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BSMIMRGEN001 == null)
            {
                return Problem("Entity set 'IMRDbContext.BSMIMRGEN001'  is null.");
            }
            var bSMIMRGEN001 = await _context.BSMIMRGEN001.FindAsync(id);
            if (bSMIMRGEN001 != null)
            {
                _context.BSMIMRGEN001.Remove(bSMIMRGEN001);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMIMRGEN001Exists(string id)
        {
          return (_context.BSMIMRGEN001?.Any(e => e.COMCODE == id)).GetValueOrDefault();
        }
        
    }
}
