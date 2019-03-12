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
    public class RecipesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecipesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Recipes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Recipes.ToListAsync());
        }
        public async Task<IActionResult> baking()
        {
            return View(await _context.Recipes.ToListAsync());
        }
        public async Task<IActionResult> breakfast()
        {
            return View(await _context.Recipes.ToListAsync());
        }
        public async Task<IActionResult> chicken()
        {
            return View(await _context.Recipes.ToListAsync());
        }
        public async Task<IActionResult> dessert()
        {
            return View(await _context.Recipes.ToListAsync());
        }
        public async Task<IActionResult> drinks()
        {
            return View(await _context.Recipes.ToListAsync());
        }
        public async Task<IActionResult> healthy()
        {
            return View(await _context.Recipes.ToListAsync());
        }
        public async Task<IActionResult> hotspot()
        {
            return View(await _context.Recipes.ToListAsync());
        }
        public async Task<IActionResult> maincourse()
        {
            return View(await _context.Recipes.ToListAsync());
        }
        public async Task<IActionResult> noodle()
        {
            return View(await _context.Recipes.ToListAsync());
        }
        public async Task<IActionResult> pasta()
        {
            return View(await _context.Recipes.ToListAsync());
        }
        public async Task<IActionResult> popcorn()
        {
            return View(await _context.Recipes.ToListAsync());
        }
        public async Task<IActionResult> quickeasy()
        {
            return View(await _context.Recipes.ToListAsync());
        }
        public async Task<IActionResult> salad()
        {
            return View(await _context.Recipes.ToListAsync());
        }
        public async Task<IActionResult> sauce()
        {
            return View(await _context.Recipes.ToListAsync());
        }
        public async Task<IActionResult> snack()
        {
            return View(await _context.Recipes.ToListAsync());
        }
        public async Task<IActionResult> vegetable()
        {
            return View(await _context.Recipes.ToListAsync());
        }

        // GET: Recipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipes = await _context.Recipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipes == null)
            {
                return NotFound();
            }

            return View(recipes);
        }

        // GET: Recipes/Create
        [Authorize(Roles ="Admin,Vip")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Recipes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Image_Food,Name_Food,Resources_prepare,Resources1,Recipe_image1,Resources2,Resources7,Recipe_image2,Resources3,Recipe_image3,Resources4,Recipe_image4,Resources5,Recipe_image5,Resources6,Recipe_image6,Step1,Recipe_image,Step2,Recipe_image2,Step3,Recipe_image3,Step4,Recipe_image4,Step5,Recipe_image5,Step6,role,Image_Practice,Image_Practice2,Image_Practice3")] Recipes recipes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recipes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recipes);
        }

        // GET: Recipes/Edit/5
        [Authorize(Roles = "Admin,Vip")]

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipes = await _context.Recipes.FindAsync(id);
            if (recipes == null)
            {
                return NotFound();
            }
            return View(recipes);
        }

        // POST: Recipes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Image_Food,Name_Food,Resources_prepare,Resources1,Recipe_image1,Resources2,Resources7,Recipe_image2,Resources3,Recipe_image3,Resources4,Recipe_image4,Resources5,Recipe_image5,Resources6,Recipe_image6,Step1,Recipe_image,Step2,Recipe_image2,Step3,Recipe_image3,Step4,Recipe_image4,Step5,Recipe_image5,Step6,role,Image_Practice,Image_Practice2,Image_Practice3")] Recipes recipes)
        {
            if (id != recipes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recipes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipesExists(recipes.Id))
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
            return View(recipes);
        }

        // GET: Recipes/Delete/5
        [Authorize(Roles = "Admin,Vip")]

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipes = await _context.Recipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipes == null)
            {
                return NotFound();
            }

            return View(recipes);
        }

        // POST: Recipes/Delete/5
        [Authorize(Roles ="Admin")]

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recipes = await _context.Recipes.FindAsync(id);
            _context.Recipes.Remove(recipes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecipesExists(int id)
        {
            return _context.Recipes.Any(e => e.Id == id);
        }
    }
}
