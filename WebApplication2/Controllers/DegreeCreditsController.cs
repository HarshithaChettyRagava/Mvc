using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DegreeCreditsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DegreeCreditsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DegreeCredits
        public async Task<IActionResult> Index(String sortOrder)
        {
            var applicationDbContext = _context.DegreeCredits.Include(d => d.Credit).Include(d => d.Degree);
            //ViewData["CreditId"] = String.IsNullOrEmpty(sortOrder) ? "CreditId" : "";
            ViewData["CreditAbrrev"] = sortOrder == "CreditAbrrev" ? "CreditAbrrev" : "CreditId";
            ViewData["CredirName"] = sortOrder == "CredirName" ? "CredirName" : "CreditId";
            ViewData["isSummer"] = sortOrder == "isSummer" ? "isSummer" : "CreditId";
            ViewData["isSpring"] = sortOrder == "isSpring" ? "isSpring" : "CreditId";
            ViewData["isFall"] = sortOrder == "isFall" ? "isFall" : "CreditId";
            var credits = from c in _context.Credits
                          select c;
            switch (sortOrder)
            {
                //case "CreditId":
                //    credits = credits.OrderByDescending(c => c.CreditId);
                //    break;
                case "CreditAbrrev":
                    credits = credits.OrderBy(c => c.CreditAbrrev);
                    break;
                case "CreditName":
                    credits = credits.OrderByDescending(c => c.CreditName);
                    break;
                case "isSummer":
                    credits = credits.OrderByDescending(c => c.isSummer);
                    break;
                case "isSpring":
                    credits = credits.OrderByDescending(c => c.isSpring);
                    break;
                case "isFall":
                    credits = credits.OrderByDescending(c => c.isFall);
                    break;

                default:
                    credits = credits.OrderByDescending(c => c.CreditId);
                    break;
            }
            return View(await credits.AsNoTracking().ToListAsync());
            //return View(await applicationDbContext.ToListAsync());
        }

        // GET: DegreeCredits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreeCredit = await _context.DegreeCredits
                .Include(d => d.Credit)
                .Include(d => d.Degree)
                .FirstOrDefaultAsync(m => m.DegreeCreditId == id);
            if (degreeCredit == null)
            {
                return NotFound();
            }

            return View(degreeCredit);
        }

        // GET: DegreeCredits/Create
        public IActionResult Create()
        {
            ViewData["CreditId"] = new SelectList(_context.Credits, "CreditId", "CreditId");
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId");
            return View();
        }

        // POST: DegreeCredits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DegreeCreditId,DegreeId,CreditId")] DegreeCredit degreeCredit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(degreeCredit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CreditId"] = new SelectList(_context.Credits, "CreditId", "CreditId", degreeCredit.CreditId);
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId", degreeCredit.DegreeId);
            return View(degreeCredit);
        }

        // GET: DegreeCredits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreeCredit = await _context.DegreeCredits.FindAsync(id);
            if (degreeCredit == null)
            {
                return NotFound();
            }
            ViewData["CreditId"] = new SelectList(_context.Credits, "CreditId", "CreditId", degreeCredit.CreditId);
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId", degreeCredit.DegreeId);
            return View(degreeCredit);
        }

        // POST: DegreeCredits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DegreeCreditId,DegreeId,CreditId")] DegreeCredit degreeCredit)
        {
            if (id != degreeCredit.DegreeCreditId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(degreeCredit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DegreeCreditExists(degreeCredit.DegreeCreditId))
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
            ViewData["CreditId"] = new SelectList(_context.Credits, "CreditId", "CreditId", degreeCredit.CreditId);
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId", degreeCredit.DegreeId);
            return View(degreeCredit);
        }

        // GET: DegreeCredits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreeCredit = await _context.DegreeCredits
                .Include(d => d.Credit)
                .Include(d => d.Degree)
                .FirstOrDefaultAsync(m => m.DegreeCreditId == id);
            if (degreeCredit == null)
            {
                return NotFound();
            }

            return View(degreeCredit);
        }

        // POST: DegreeCredits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var degreeCredit = await _context.DegreeCredits.FindAsync(id);
            _context.DegreeCredits.Remove(degreeCredit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DegreeCreditExists(int id)
        {
            return _context.DegreeCredits.Any(e => e.DegreeCreditId == id);
        }
    }
}
