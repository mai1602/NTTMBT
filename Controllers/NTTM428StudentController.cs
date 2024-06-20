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
    public class NTTM428StudentController : Controller
    {
        private readonly LTQDD _context;

        public NTTM428StudentController(LTQDD context)
        {
            _context = context;
        }

        // GET: NTTM428Student
        public async Task<IActionResult> Index()
        {
              return _context.NTTM428Student != null ? 
                          View(await _context.NTTM428Student.ToListAsync()) :
                          Problem("Entity set 'LTQDD.NTTM428Student'  is null.");
        }

        // GET: NTTM428Student/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NTTM428Student == null)
            {
                return NotFound();
            }

            var nTTM428Student = await _context.NTTM428Student
                .FirstOrDefaultAsync(m => m.CCCN == id);
            if (nTTM428Student == null)
            {
                return NotFound();
            }

            return View(nTTM428Student);
        }

        // GET: NTTM428Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NTTM428Student/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CCCN,TenSinhVien,LopHoc")] NTTM428Student nTTM428Student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTTM428Student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTTM428Student);
        }

        // GET: NTTM428Student/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NTTM428Student == null)
            {
                return NotFound();
            }

            var nTTM428Student = await _context.NTTM428Student.FindAsync(id);
            if (nTTM428Student == null)
            {
                return NotFound();
            }
            return View(nTTM428Student);
        }

        // POST: NTTM428Student/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CCCN,TenSinhVien,LopHoc")] NTTM428Student nTTM428Student)
        {
            if (id != nTTM428Student.CCCN)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTTM428Student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTTM428StudentExists(nTTM428Student.CCCN))
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
            return View(nTTM428Student);
        }

        // GET: NTTM428Student/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NTTM428Student == null)
            {
                return NotFound();
            }

            var nTTM428Student = await _context.NTTM428Student
                .FirstOrDefaultAsync(m => m.CCCN == id);
            if (nTTM428Student == null)
            {
                return NotFound();
            }

            return View(nTTM428Student);
        }

        // POST: NTTM428Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NTTM428Student == null)
            {
                return Problem("Entity set 'LTQDD.NTTM428Student'  is null.");
            }
            var nTTM428Student = await _context.NTTM428Student.FindAsync(id);
            if (nTTM428Student != null)
            {
                _context.NTTM428Student.Remove(nTTM428Student);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTTM428StudentExists(string id)
        {
          return (_context.NTTM428Student?.Any(e => e.CCCN == id)).GetValueOrDefault();
        }
    }
}
