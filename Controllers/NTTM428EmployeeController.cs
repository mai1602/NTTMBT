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
    public class NTTM428EmployeeController : Controller
    {
        private readonly LTQDD _context;

        public NTTM428EmployeeController(LTQDD context)
        {
            _context = context;
        }

        // GET: NTTM428Employee
        public async Task<IActionResult> Index()
        {
              return _context.NTTM428Employee != null ? 
                          View(await _context.NTTM428Employee.ToListAsync()) :
                          Problem("Entity set 'LTQDD.NTTM428Employee'  is null.");
        }

        // GET: NTTM428Employee/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NTTM428Employee == null)
            {
                return NotFound();
            }

            var nTTM428Employee = await _context.NTTM428Employee
                .FirstOrDefaultAsync(m => m.EmployeeID == id);
            if (nTTM428Employee == null)
            {
                return NotFound();
            }

            return View(nTTM428Employee);
        }

        // GET: NTTM428Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NTTM428Employee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeID,TenSinhVien,LopHoc")] NTTM428Employee nTTM428Employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTTM428Employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTTM428Employee);
        }

        // GET: NTTM428Employee/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NTTM428Employee == null)
            {
                return NotFound();
            }

            var nTTM428Employee = await _context.NTTM428Employee.FindAsync(id);
            if (nTTM428Employee == null)
            {
                return NotFound();
            }
            return View(nTTM428Employee);
        }

        // POST: NTTM428Employee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("EmployeeID,TenSinhVien,LopHoc")] NTTM428Employee nTTM428Employee)
        {
            if (id != nTTM428Employee.EmployeeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTTM428Employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTTM428EmployeeExists(nTTM428Employee.EmployeeID))
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
            return View(nTTM428Employee);
        }

        // GET: NTTM428Employee/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NTTM428Employee == null)
            {
                return NotFound();
            }

            var nTTM428Employee = await _context.NTTM428Employee
                .FirstOrDefaultAsync(m => m.EmployeeID == id);
            if (nTTM428Employee == null)
            {
                return NotFound();
            }

            return View(nTTM428Employee);
        }

        // POST: NTTM428Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NTTM428Employee == null)
            {
                return Problem("Entity set 'LTQDD.NTTM428Employee'  is null.");
            }
            var nTTM428Employee = await _context.NTTM428Employee.FindAsync(id);
            if (nTTM428Employee != null)
            {
                _context.NTTM428Employee.Remove(nTTM428Employee);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTTM428EmployeeExists(string id)
        {
          return (_context.NTTM428Employee?.Any(e => e.EmployeeID == id)).GetValueOrDefault();
        }
    }
}
