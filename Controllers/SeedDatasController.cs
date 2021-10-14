using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Buckles.Data;
using Buckles.Models;

namespace Buckles.Controllers
{
    public class SeedDatasController : Controller
    {
        private readonly BucklesContext _context;

        public SeedDatasController(BucklesContext context)
        {
            _context = context;
        }

        // GET: SeedDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.SeedData.ToListAsync());
        }

        // GET: SeedDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seedData = await _context.SeedData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (seedData == null)
            {
                return NotFound();
            }

            return View(seedData);
        }

        // GET: SeedDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SeedDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Productname,Description,Rating,Price")] SeedData seedData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seedData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(seedData);
        }

        // GET: SeedDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seedData = await _context.SeedData.FindAsync(id);
            if (seedData == null)
            {
                return NotFound();
            }
            return View(seedData);
        }

        // POST: SeedDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Productname,Description,Rating,Price")] SeedData seedData)
        {
            if (id != seedData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seedData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SeedDataExists(seedData.Id))
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
            return View(seedData);
        }

        // GET: SeedDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seedData = await _context.SeedData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (seedData == null)
            {
                return NotFound();
            }

            return View(seedData);
        }

        // POST: SeedDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seedData = await _context.SeedData.FindAsync(id);
            _context.SeedData.Remove(seedData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SeedDataExists(int id)
        {
            return _context.SeedData.Any(e => e.Id == id);
        }
    }
}
