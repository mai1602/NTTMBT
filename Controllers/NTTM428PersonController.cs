using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NTTMBT.Models;

namespace NTTMBT.Controllers
{
    public class NTTM428PersonController : Controller
    {
        private readonly LTQDD _context;

        public NTTM428PersonController(LTQDD context)
        {
            _context = context;
        }

        // GET: NTTM428Person
        public async Task<IActionResult> Index()
        {
              return _context.NTTM428Person != null ? 
                          View(await _context.NTTM428Person.ToListAsync()) :
                          Problem("Entity set 'LTQDD.NTTM428Person'  is null.");
        }

        // GET: NTTM428Person/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NTTM428Person == null)
            {
                return NotFound();
            }

            var nTTM428Person = await _context.NTTM428Person
                .FirstOrDefaultAsync(m => m.MaSinhVien == id);
            if (nTTM428Person == null)
            {
                return NotFound();
            }

            return View(nTTM428Person);
        }

        // GET: NTTM428Person/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NTTM428Person/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaSinhVien,TenSinhVien,LopHoc")] NTTM428Person nTTM428Person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTTM428Person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTTM428Person);
        }

        // GET: NTTM428Person/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NTTM428Person == null)
            {
                return NotFound();
            }

            var nTTM428Person = await _context.NTTM428Person.FindAsync(id);
            if (nTTM428Person == null)
            {
                return NotFound();
            }
            return View(nTTM428Person);
        }

        // POST: NTTM428Person/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaSinhVien,TenSinhVien,LopHoc")] NTTM428Person nTTM428Person)
        {
            if (id != nTTM428Person.MaSinhVien)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTTM428Person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTTM428PersonExists(nTTM428Person.MaSinhVien))
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
            return View(nTTM428Person);
        }

        // GET: NTTM428Person/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NTTM428Person == null)
            {
                return NotFound();
            }

            var nTTM428Person = await _context.NTTM428Person
                .FirstOrDefaultAsync(m => m.MaSinhVien == id);
            if (nTTM428Person == null)
            {
                return NotFound();
            }

            return View(nTTM428Person);
        }

        // POST: NTTM428Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NTTM428Person == null)
            {
                return Problem("Entity set 'LTQDD.NTTM428Person'  is null.");
            }
            var nTTM428Person = await _context.NTTM428Person.FindAsync(id);
            if (nTTM428Person != null)
            {
                _context.NTTM428Person.Remove(nTTM428Person);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTTM428PersonExists(string id)
        {
          return (_context.NTTM428Person?.Any(e => e.MaSinhVien == id)).GetValueOrDefault();
        }
    }
}
