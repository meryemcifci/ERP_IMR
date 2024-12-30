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
    public class BSMIMRGEN002Controller : Controller
    {
        private readonly IMRDbContext _context;

        public BSMIMRGEN002Controller(IMRDbContext context)
        {
            _context = context;
        }

        // GET: BSMIMRGEN002
        public async Task<IActionResult> Index()
        {
              return _context.BSMIMRGEN002 != null ? 
                          View(await _context.BSMIMRGEN002.ToListAsync()) :
                          Problem("Entity set 'IMRDbContext.BSMIMRGEN002'  is null.");
        }

        // GET: BSMIMRGEN002/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BSMIMRGEN002 == null)
            {
                return NotFound();
            }

            var bSMIMRGEN002 = await _context.BSMIMRGEN002
                .FirstOrDefaultAsync(m => m.LANCODE == id);
            if (bSMIMRGEN002 == null)
            {
                return NotFound();
            }

            return View(bSMIMRGEN002);
        }

        // GET: BSMIMRGEN002/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BSMIMRGEN002/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("COMCODE,LANCODE,LANTEXT")] BSMIMRGEN002 bSMIMRGEN002)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMIMRGEN002);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bSMIMRGEN002);
        }

        // GET: BSMIMRGEN002/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BSMIMRGEN002 == null)
            {
                return NotFound();
            }

            var bSMIMRGEN002 = await _context.BSMIMRGEN002.FindAsync(id);
            if (bSMIMRGEN002 == null)
            {
                return NotFound();
            }
            return View(bSMIMRGEN002);
        }

        // POST: BSMIMRGEN002/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("COMCODE,LANCODE,LANTEXT")] BSMIMRGEN002 bSMIMRGEN002)
        {
            if (id != bSMIMRGEN002.LANCODE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMIMRGEN002);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMIMRGEN002Exists(bSMIMRGEN002.LANCODE))
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
            return View(bSMIMRGEN002);
        }

        // GET: BSMIMRGEN002/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BSMIMRGEN002 == null)
            {
                return NotFound();
            }

            var bSMIMRGEN002 = await _context.BSMIMRGEN002
                .FirstOrDefaultAsync(m => m.LANCODE == id);
            if (bSMIMRGEN002 == null)
            {
                return NotFound();
            }

            return View(bSMIMRGEN002);
        }

        // POST: BSMIMRGEN002/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BSMIMRGEN002 == null)
            {
                return Problem("Entity set 'IMRDbContext.BSMIMRGEN002'  is null.");
            }
            var bSMIMRGEN002 = await _context.BSMIMRGEN002.FindAsync(id);
            if (bSMIMRGEN002 != null)
            {
                _context.BSMIMRGEN002.Remove(bSMIMRGEN002);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMIMRGEN002Exists(string id)
        {
          return (_context.BSMIMRGEN002?.Any(e => e.LANCODE == id)).GetValueOrDefault();
        }
    }
}
