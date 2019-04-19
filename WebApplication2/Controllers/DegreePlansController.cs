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
    public class DegreePlansController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DegreePlansController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DegreePlans
        public async Task<IActionResult> Index(String sortOrder, String searchString)
        {
            var applicationDbContext = _context.DegreePlans.Include(d => d.Degree).Include(d => d.Student);
            ViewData["DegreePlanId"] = String.IsNullOrEmpty(sortOrder) ? "DegreePlanId" : "";
            ViewData["StudentId"] = sortOrder == "StudentId" ? "StudentId" : "DegreePlanId";
            ViewData["DegreePlanAbbrev"] = sortOrder == "DegreePlanAbbrev" ? "DegreePlanAbbrev" : "DegreePlanId";
            ViewData["DegreePlanName"] = sortOrder == "DegreePlanName" ? "DegreePlanName" : "DegreePlanId";
            ViewData["DegreeId"] = sortOrder == "DegreeId" ? "DegreeId" : "DegreePlanId";
            ViewData["CurrentFilter"] = searchString;

            var degreePlans = from dp in _context.DegreePlans
                              select dp;

            if (!String.IsNullOrEmpty(searchString))
            {
                degreePlans = degreePlans.Where(s => s.DegreePlanAbbrev.Contains(searchString) ||
                                                       s.DegreePlanName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "DegreePlanId":
                    degreePlans = degreePlans.OrderByDescending(dp => dp.DegreePlanId);
                    break;
                case "StudentId":
                    degreePlans = degreePlans.OrderBy(dp => dp.StudentId);
                    break;
                case "DegreePlanAbbrev":
                    degreePlans = degreePlans.OrderByDescending(dp => dp.DegreePlanAbbrev);
                    break;
                case "DegreePlanName":
                    degreePlans = degreePlans.OrderByDescending(dp => dp.DegreePlanName);
                    break;
                case "DegreeId":
                    degreePlans = degreePlans.OrderByDescending(dp => dp.DegreeId);
                    break;
                default:
                    degreePlans = degreePlans.OrderByDescending(dp => dp.DegreePlanId);
                    break;
            }
            return View(await degreePlans.AsNoTracking().ToListAsync());
            //return View(await applicationDbContext.ToListAsync());
        }

        // GET: DegreePlans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreePlan = await _context.DegreePlans
                .Include(d => d.Degree)
                .Include(d => d.Student)
                .FirstOrDefaultAsync(m => m.DegreePlanId == id);
            if (degreePlan == null)
            {
                return NotFound();
            }

            return View(degreePlan);
        }

        // GET: DegreePlans/Create
        public IActionResult Create()
        {
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId");
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId");
            return View();
        }

        // POST: DegreePlans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DegreePlanId,StudentId,DegreePlanAbbrev,DegreePlanName,DegreeId")] DegreePlan degreePlan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(degreePlan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId", degreePlan.DegreeId);
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId", degreePlan.StudentId);
            return View(degreePlan);
        }

        // GET: DegreePlans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreePlan = await _context.DegreePlans.FindAsync(id);
            if (degreePlan == null)
            {
                return NotFound();
            }
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId", degreePlan.DegreeId);
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId", degreePlan.StudentId);
            return View(degreePlan);
        }

        // POST: DegreePlans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DegreePlanId,StudentId,DegreePlanAbbrev,DegreePlanName,DegreeId")] DegreePlan degreePlan)
        {
            if (id != degreePlan.DegreePlanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(degreePlan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DegreePlanExists(degreePlan.DegreePlanId))
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
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId", degreePlan.DegreeId);
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId", degreePlan.StudentId);
            return View(degreePlan);
        }

        // GET: DegreePlans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreePlan = await _context.DegreePlans
                .Include(d => d.Degree)
                .Include(d => d.Student)
                .FirstOrDefaultAsync(m => m.DegreePlanId == id);
            if (degreePlan == null)
            {
                return NotFound();
            }

            return View(degreePlan);
        }

        // POST: DegreePlans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var degreePlan = await _context.DegreePlans.FindAsync(id);
            _context.DegreePlans.Remove(degreePlan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DegreePlanExists(int id)
        {
            return _context.DegreePlans.Any(e => e.DegreePlanId == id);
        }
    }
}
