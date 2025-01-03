using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP_IMR.Models;
using ERP_IMR.Models.Deneme;

namespace ERP_IMR.Controllers.Deneme
{
    public class BSMIMRCCMHEADTEXTController : Controller
    {
        private readonly IMRDbContext _context;

        public BSMIMRCCMHEADTEXTController(IMRDbContext context)
        {
            _context = context;
        }

        // GET: BSMIMRCCMHEADTEXT
        public async Task<IActionResult> Index()
        {
              return _context.BSMIMRCCMHEADTEXT != null ? 
                          View(await _context.BSMIMRCCMHEADTEXT.ToListAsync()) :
                          Problem("Entity set 'IMRDbContext.BSMIMRCCMHEADTEXT'  is null.");
        }

        // GET: BSMIMRCCMHEADTEXT/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BSMIMRCCMHEADTEXT == null)
            {
                return NotFound();
            }

            var bSMIMRCCMHEADTEXT = await _context.BSMIMRCCMHEADTEXT
                .FirstOrDefaultAsync(m => m.CCMDOCNUM == id);
            if (bSMIMRCCMHEADTEXT == null)
            {
                return NotFound();
            }

            return View(bSMIMRCCMHEADTEXT);
        }

        // GET: BSMIMRCCMHEADTEXT/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BSMIMRCCMHEADTEXT/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("COMCODE,CCMDOCTYPE,CCMDOCNUM,CCMDOCFROM,CCMDOCUNTIL,MAINCCMDOCTYPE,MAINCCMDOCNUM,ISDELETED,ISPASSIVE,LANCODE,CCMSTEXT,CCMLTEXT")] BSMIMRCCMHEADTEXT bSMIMRCCMHEADTEXT)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMIMRCCMHEADTEXT);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bSMIMRCCMHEADTEXT);
        }

        // GET: BSMIMRCCMHEADTEXT/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BSMIMRCCMHEADTEXT == null)
            {
                return NotFound();
            }

            var bSMIMRCCMHEADTEXT = await _context.BSMIMRCCMHEADTEXT.FindAsync(id);
            if (bSMIMRCCMHEADTEXT == null)
            {
                return NotFound();
            }
            return View(bSMIMRCCMHEADTEXT);
        }

        // POST: BSMIMRCCMHEADTEXT/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("COMCODE,CCMDOCTYPE,CCMDOCNUM,CCMDOCFROM,CCMDOCUNTIL,MAINCCMDOCTYPE,MAINCCMDOCNUM,ISDELETED,ISPASSIVE,LANCODE,CCMSTEXT,CCMLTEXT")] BSMIMRCCMHEADTEXT bSMIMRCCMHEADTEXT)
        {
            if (id != bSMIMRCCMHEADTEXT.CCMDOCNUM)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMIMRCCMHEADTEXT);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMIMRCCMHEADTEXTExists(bSMIMRCCMHEADTEXT.CCMDOCNUM))
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
            return View(bSMIMRCCMHEADTEXT);
        }

        // GET: BSMIMRCCMHEADTEXT/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BSMIMRCCMHEADTEXT == null)
            {
                return NotFound();
            }

            var bSMIMRCCMHEADTEXT = await _context.BSMIMRCCMHEADTEXT
                .FirstOrDefaultAsync(m => m.CCMDOCNUM == id);
            if (bSMIMRCCMHEADTEXT == null)
            {
                return NotFound();
            }

            return View(bSMIMRCCMHEADTEXT);
        }

        // POST: BSMIMRCCMHEADTEXT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BSMIMRCCMHEADTEXT == null)
            {
                return Problem("Entity set 'IMRDbContext.BSMIMRCCMHEADTEXT'  is null.");
            }
            var bSMIMRCCMHEADTEXT = await _context.BSMIMRCCMHEADTEXT.FindAsync(id);
            if (bSMIMRCCMHEADTEXT != null)
            {
                _context.BSMIMRCCMHEADTEXT.Remove(bSMIMRCCMHEADTEXT);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMIMRCCMHEADTEXTExists(string id)
        {
          return (_context.BSMIMRCCMHEADTEXT?.Any(e => e.CCMDOCNUM == id)).GetValueOrDefault();
        }
    }
}
