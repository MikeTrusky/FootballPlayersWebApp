using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FootballPlayersWebApp.Data;
using FootballPlayersWebApp.Models;

namespace FootballPlayersWebApp.Controllers
{
    public class FootballersController : Controller
    {
        private readonly FootballPlayersWebAppContext _context;

        public FootballersController(FootballPlayersWebAppContext context)
        {
            _context = context;
        }

        // GET: Footballers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Footballer.ToListAsync());
        }

        // GET: Footballers/ShowSearchForm
        public async Task<IActionResult> ShowSearchForm()
        {
            return View();
        }

        // PoST: Footballers/ShowSearchResults
        public async Task<IActionResult> ShowSearchResults(String SearchPhrase)
        {
            return View(await _context.Footballer.Where(j => j.FootballerName.Contains(SearchPhrase)).ToListAsync());
        }

        // GET: Footballers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footballer = await _context.Footballer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (footballer == null)
            {
                return NotFound();
            }

            return View(footballer);
        }

        // GET: Footballers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Footballers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FootballerName,FootballerClub")] Footballer footballer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(footballer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(footballer);
        }

        // GET: Footballers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footballer = await _context.Footballer.FindAsync(id);
            if (footballer == null)
            {
                return NotFound();
            }
            return View(footballer);
        }

        // POST: Footballers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FootballerName,FootballerClub")] Footballer footballer)
        {
            if (id != footballer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(footballer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FootballerExists(footballer.Id))
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
            return View(footballer);
        }

        // GET: Footballers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footballer = await _context.Footballer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (footballer == null)
            {
                return NotFound();
            }

            return View(footballer);
        }

        // POST: Footballers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var footballer = await _context.Footballer.FindAsync(id);
            _context.Footballer.Remove(footballer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FootballerExists(int id)
        {
            return _context.Footballer.Any(e => e.Id == id);
        }
    }
}
