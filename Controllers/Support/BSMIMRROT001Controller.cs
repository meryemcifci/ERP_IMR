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
    public class BSMIMRROT001Controller : Controller
    {
        private readonly IMRDbContext _context;

        public BSMIMRROT001Controller(IMRDbContext context)
        {
            _context = context;
        }

        // GET: BSMIMRROT001
        public async Task<IActionResult> Index()
        {
              return _context.BSMIMRROT001 != null ? 
                          View(await _context.BSMIMRROT001.ToListAsync()) :
                          Problem("Entity set 'IMRDbContext.BSMIMRROT001'  is null.");
        }

        // GET: BSMIMRROT001/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BSMIMRROT001 == null)
            {
                return NotFound();
            }

            var bSMIMRROT001 = await _context.BSMIMRROT001
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMIMRROT001 == null)
            {
                return NotFound();
            }

            return View(bSMIMRROT001);
        }

        // GET: BSMIMRROT001/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BSMIMRROT001/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DOCTYPE,COMCODE,DOCTYPETEXT,ISPASSIVE")] BSMIMRROT001 bSMIMRROT001)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMIMRROT001);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bSMIMRROT001);
        }

        // GET: BSMIMRROT001/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BSMIMRROT001 == null)
            {
                return NotFound();
            }

            var bSMIMRROT001 = await _context.BSMIMRROT001.FindAsync(id);
            if (bSMIMRROT001 == null)
            {
                return NotFound();
            }
            return View(bSMIMRROT001);
        }

        // POST: BSMIMRROT001/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DOCTYPE,COMCODE,DOCTYPETEXT,ISPASSIVE")] BSMIMRROT001 bSMIMRROT001)
        {
            if (id != bSMIMRROT001.DOCTYPE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMIMRROT001);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMIMRROT001Exists(bSMIMRROT001.DOCTYPE))
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
            return View(bSMIMRROT001);
        }

        // GET: BSMIMRROT001/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BSMIMRROT001 == null)
            {
                return NotFound();
            }

            var bSMIMRROT001 = await _context.BSMIMRROT001
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMIMRROT001 == null)
            {
                return NotFound();
            }

            return View(bSMIMRROT001);
        }

        // POST: BSMIMRROT001/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BSMIMRROT001 == null)
            {
                return Problem("Entity set 'IMRDbContext.BSMIMRROT001'  is null.");
            }
            var bSMIMRROT001 = await _context.BSMIMRROT001.FindAsync(id);
            if (bSMIMRROT001 != null)
            {
                _context.BSMIMRROT001.Remove(bSMIMRROT001);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMIMRROT001Exists(string id)
        {
          return (_context.BSMIMRROT001?.Any(e => e.DOCTYPE == id)).GetValueOrDefault();
        }
    }
}
