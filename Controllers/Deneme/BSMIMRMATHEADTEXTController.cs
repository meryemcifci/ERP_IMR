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
    public class BSMIMRMATHEADTEXTController : Controller
    {
        private readonly IMRDbContext _context;

        public BSMIMRMATHEADTEXTController(IMRDbContext context)
        {
            _context = context;
        }

        // GET: BSMIMRMATHEADTEXT
        public async Task<IActionResult> Index()
        {
              return _context.BSMIMRMATHEADTEXT != null ? 
                          View(await _context.BSMIMRMATHEADTEXT.ToListAsync()) :
                          Problem("Entity set 'IMRDbContext.BSMIMRMATHEADTEXT'  is null.");
        }

        // GET: BSMIMRMATHEADTEXT/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BSMIMRMATHEADTEXT == null)
            {
                return NotFound();
            }

            var bSMIMRMATHEADTEXT = await _context.BSMIMRMATHEADTEXT
                .FirstOrDefaultAsync(m => m.MATDOCNUM == id);
            if (bSMIMRMATHEADTEXT == null)
            {
                return NotFound();
            }

            return View(bSMIMRMATHEADTEXT);
        }

        // GET: BSMIMRMATHEADTEXT/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BSMIMRMATHEADTEXT/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("COMCODE,MATDOCTYPE,MATDOCNUM,MATDOCFROM,MATDOCUNTIL,SUPPLYTYPE,STUNIT,NETWEIGHT,NWUNIT,BRUTWEIGHT,BWUNIT,ISBOM,BOMDOCTYPE,BOMDOCNUM,ISROUTE,ROTDOCTYPE,ROTDOCNUM,ISDELETED,ISPASSIVE,LANCODE,MATSTEXT,MATLTEXT")] BSMIMRMATHEADTEXT bSMIMRMATHEADTEXT)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bSMIMRMATHEADTEXT);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bSMIMRMATHEADTEXT);
        }

        // GET: BSMIMRMATHEADTEXT/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BSMIMRMATHEADTEXT == null)
            {
                return NotFound();
            }

            var bSMIMRMATHEADTEXT = await _context.BSMIMRMATHEADTEXT.FindAsync(id);
            if (bSMIMRMATHEADTEXT == null)
            {
                return NotFound();
            }
            return View(bSMIMRMATHEADTEXT);
        }

        // POST: BSMIMRMATHEADTEXT/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("COMCODE,MATDOCTYPE,MATDOCNUM,MATDOCFROM,MATDOCUNTIL,SUPPLYTYPE,STUNIT,NETWEIGHT,NWUNIT,BRUTWEIGHT,BWUNIT,ISBOM,BOMDOCTYPE,BOMDOCNUM,ISROUTE,ROTDOCTYPE,ROTDOCNUM,ISDELETED,ISPASSIVE,LANCODE,MATSTEXT,MATLTEXT")] BSMIMRMATHEADTEXT bSMIMRMATHEADTEXT)
        {
            if (id != bSMIMRMATHEADTEXT.MATDOCNUM)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bSMIMRMATHEADTEXT);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BSMIMRMATHEADTEXTExists(bSMIMRMATHEADTEXT.MATDOCNUM))
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
            return View(bSMIMRMATHEADTEXT);
        }

        // GET: BSMIMRMATHEADTEXT/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BSMIMRMATHEADTEXT == null)
            {
                return NotFound();
            }

            var bSMIMRMATHEADTEXT = await _context.BSMIMRMATHEADTEXT
                .FirstOrDefaultAsync(m => m.MATDOCNUM == id);
            if (bSMIMRMATHEADTEXT == null)
            {
                return NotFound();
            }

            return View(bSMIMRMATHEADTEXT);
        }

        // POST: BSMIMRMATHEADTEXT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BSMIMRMATHEADTEXT == null)
            {
                return Problem("Entity set 'IMRDbContext.BSMIMRMATHEADTEXT'  is null.");
            }
            var bSMIMRMATHEADTEXT = await _context.BSMIMRMATHEADTEXT.FindAsync(id);
            if (bSMIMRMATHEADTEXT != null)
            {
                _context.BSMIMRMATHEADTEXT.Remove(bSMIMRMATHEADTEXT);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BSMIMRMATHEADTEXTExists(string id)
        {
          return (_context.BSMIMRMATHEADTEXT?.Any(e => e.MATDOCNUM == id)).GetValueOrDefault();
        }
    }
}
