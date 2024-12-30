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
    public class BSMIMRMAT001Controller : Controller
    {
        private readonly IMRDbContext _context;

        public BSMIMRMAT001Controller(IMRDbContext context)
        {
            _context = context;
        }

        // GET: BSMIMRMAT001
        public async Task<IActionResult> Index()
        {
              return _context.BSMIMRMAT001 != null ? 
                          View(await _context.BSMIMRMAT001.ToListAsync()) :
                          Problem("Entity set 'IMRDbContext.BSMIMRMAT001'  is null.");
        }

        // GET: BSMIMRMAT001/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BSMIMRMAT001 == null)
            {
                return NotFound();
            }

            var bSMIMRMAT001 = await _context.BSMIMRMAT001
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMIMRMAT001 == null)
            {
                return NotFound();
            }

            return View(bSMIMRMAT001);
        }

        // GET: BSMIMRMAT001/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BSMIMRMAT001/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DOCTYPE,COMCODE,DOCTYPETEXT,ISPASSIVE")] BSMIMRMAT001 bSMIMRMAT001)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMIMRMAT001);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bSMIMRMAT001);
        }

        // GET: BSMIMRMAT001/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BSMIMRMAT001 == null)
            {
                return NotFound();
            }

            var bSMIMRMAT001 = await _context.BSMIMRMAT001.FindAsync(id);
            if (bSMIMRMAT001 == null)
            {
                return NotFound();
            }
            return View(bSMIMRMAT001);
        }

        // POST: BSMIMRMAT001/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DOCTYPE,COMCODE,DOCTYPETEXT,ISPASSIVE")] BSMIMRMAT001 bSMIMRMAT001)
        {
            if (id != bSMIMRMAT001.DOCTYPE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMIMRMAT001);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMIMRMAT001Exists(bSMIMRMAT001.DOCTYPE))
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
            return View(bSMIMRMAT001);
        }

        // GET: BSMIMRMAT001/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BSMIMRMAT001 == null)
            {
                return NotFound();
            }

            var bSMIMRMAT001 = await _context.BSMIMRMAT001
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMIMRMAT001 == null)
            {
                return NotFound();
            }

            return View(bSMIMRMAT001);
        }

        // POST: BSMIMRMAT001/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BSMIMRMAT001 == null)
            {
                return Problem("Entity set 'IMRDbContext.BSMIMRMAT001'  is null.");
            }
            var bSMIMRMAT001 = await _context.BSMIMRMAT001.FindAsync(id);
            if (bSMIMRMAT001 != null)
            {
                _context.BSMIMRMAT001.Remove(bSMIMRMAT001);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMIMRMAT001Exists(string id)
        {
          return (_context.BSMIMRMAT001?.Any(e => e.DOCTYPE == id)).GetValueOrDefault();
        }
    }
}
