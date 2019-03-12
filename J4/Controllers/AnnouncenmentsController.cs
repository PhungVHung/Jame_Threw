using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using J4.Data;
using J4.Models;
using Microsoft.AspNetCore.Authorization;

namespace J4.Controllers
{
    public class AnnouncenmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AnnouncenmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Announcenments
        public async Task<IActionResult> Index()
        {
            return View(await _context.Announcenment.ToListAsync());
        }

        // GET: Announcenments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var announcenment = await _context.Announcenment
                .FirstOrDefaultAsync(m => m.Id_announ == id);
            if (announcenment == null)
            {
                return NotFound();
            }

            return View(announcenment);
        }

        // GET: Announcenments/Create
        [Authorize(Roles = "Admin,Vip")]

        public IActionResult Create()
        {
            return View();
        }

        // POST: Announcenments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_announ,Tittle_announ,Describle_announ,Image_announ")] Announcenment announcenment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(announcenment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(announcenment);
        }

        // GET: Announcenments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var announcenment = await _context.Announcenment.FindAsync(id);
            if (announcenment == null)
            {
                return NotFound();
            }
            return View(announcenment);
        }

        // POST: Announcenments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_announ,Tittle_announ,Describle_announ,Image_announ")] Announcenment announcenment)
        {
            if (id != announcenment.Id_announ)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(announcenment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnnouncenmentExists(announcenment.Id_announ))
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
            return View(announcenment);
        }

        // GET: Announcenments/Delete/5
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var announcenment = await _context.Announcenment
                .FirstOrDefaultAsync(m => m.Id_announ == id);
            if (announcenment == null)
            {
                return NotFound();
            }

            return View(announcenment);
        }

        // POST: Announcenments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var announcenment = await _context.Announcenment.FindAsync(id);
            _context.Announcenment.Remove(announcenment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnnouncenmentExists(int id)
        {
            return _context.Announcenment.Any(e => e.Id_announ == id);
        }
    }
}
