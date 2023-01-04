using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppLong.Models;

namespace WebAppLong.Controllers
{
    public class NhanVienController : Controller
    {
        private readonly QlnvContext _context;

        public NhanVienController(QlnvContext context)
        {
            _context = context;
        }

        // GET: NhanVien
        public async Task<IActionResult> Index()
        {
              return View(await _context.NhanViens.ToListAsync());
        }

        // GET: NhanVien/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NhanViens == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanViens
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nhanVien == null)
            {
                return NotFound();
            }

            return View(nhanVien);
        }

        // GET: NhanVien/Create
        public IActionResult Create()
        {
            //List<NhanVien> nhanViens = _context.NhanViens.ToList();
            //return View(nhanViens);
            return View();
        }

        // POST: NhanVien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,Password,ConfirmPassword,Email,Tel,Disabled")] NhanVien nhanVien)
        {
            if (ModelState.IsValid)
              
            {
                _context.Add(nhanVien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(await _context.NhanViens.ToListAsync());
           
        }
        

        // GET: NhanVien/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NhanViens == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanViens.FindAsync(id);
            if (nhanVien == null)
            {
                return NotFound();
            }
            return View(nhanVien);
        }

        // POST: NhanVien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,UserName,Password,Email,Tel,Disabled")] NhanVien nhanVien)
        {
            if (id != nhanVien.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhanVien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhanVienExists(nhanVien.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.NhanViens.ToList()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Edit", nhanVien) });
        }

        // GET: NhanVien/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NhanViens == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanViens
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nhanVien == null)
            {
                return NotFound();
            }

            return View(nhanVien);
        }

        // POST: NhanVien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NhanViens == null)
            {
                return Problem("Entity set 'QlnvContext.NhanViens'  is null.");
            }
            var nhanVien = await _context.NhanViens.FindAsync(id);
            if (nhanVien != null)
            {
                _context.NhanViens.Remove(nhanVien);
            }
            
            await _context.SaveChangesAsync();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.NhanViens.ToList()) });
        }

        private bool NhanVienExists(string id)
        {
          return _context.NhanViens.Any(e => e.Id == id);
        }
    }
}
