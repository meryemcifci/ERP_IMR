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
    public class BSMIMRBOM001Controller : Controller
    {
        private readonly IMRDbContext _context;

        public BSMIMRBOM001Controller(IMRDbContext context)
        {
            _context = context;
        }

        // GET: BSMIMRBOM001
        public async Task<IActionResult> Index()
        {
              return _context.BSMIMRBOM001 != null ? 
                          View(await _context.BSMIMRBOM001.ToListAsync()) :
                          Problem("Entity set 'IMRDbContext.BSMIMRBOM001'  is null.");
        }

        // GET: BSMIMRBOM001/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BSMIMRBOM001 == null)
            {
                return NotFound();
            }

            var bSMIMRBOM001 = await _context.BSMIMRBOM001
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMIMRBOM001 == null)
            {
                return NotFound();
            }

            return View(bSMIMRBOM001);
        }

        // GET: BSMIMRBOM001/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BSMIMRBOM001/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DOCTYPE,COMCODE,DOCTYPETEXT,ISPASSIVE")] BSMIMRBOM001 bSMIMRBOM001)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMIMRBOM001);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bSMIMRBOM001);
        }

        // GET: BSMIMRBOM001/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BSMIMRBOM001 == null)
            {
                return NotFound();
            }

            var bSMIMRBOM001 = await _context.BSMIMRBOM001.FindAsync(id);
            if (bSMIMRBOM001 == null)
            {
                return NotFound();
            }
            return View(bSMIMRBOM001);
        }

        // POST: BSMIMRBOM001/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DOCTYPE,COMCODE,DOCTYPETEXT,ISPASSIVE")] BSMIMRBOM001 bSMIMRBOM001)
        {
            if (id != bSMIMRBOM001.DOCTYPE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMIMRBOM001);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMIMRBOM001Exists(bSMIMRBOM001.DOCTYPE))
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
            return View(bSMIMRBOM001);
        }

        // GET: BSMIMRBOM001/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BSMIMRBOM001 == null)
            {
                return NotFound();
            }

            var bSMIMRBOM001 = await _context.BSMIMRBOM001
                .FirstOrDefaultAsync(m => m.DOCTYPE == id);
            if (bSMIMRBOM001 == null)
            {
                return NotFound();
            }

            return View(bSMIMRBOM001);
        }

        // POST: BSMIMRBOM001/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BSMIMRBOM001 == null)
            {
                return Problem("Entity set 'IMRDbContext.BSMIMRBOM001'  is null.");
            }
            var bSMIMRBOM001 = await _context.BSMIMRBOM001.FindAsync(id);
            if (bSMIMRBOM001 != null)
            {
                _context.BSMIMRBOM001.Remove(bSMIMRBOM001);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMIMRBOM001Exists(string id)
        {
          return (_context.BSMIMRBOM001?.Any(e => e.DOCTYPE == id)).GetValueOrDefault();
        }
    }
}
