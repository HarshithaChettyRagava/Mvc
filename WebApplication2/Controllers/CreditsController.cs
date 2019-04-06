﻿using System;
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
    public class CreditsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CreditsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Credits
        public async Task<IActionResult> Index(String sortOrder)
        {
            var applicationDbContext = _context.DegreeCredits.Include(d => d.Credit).Include(d => d.Degree);
            ViewData["CreditId"] = String.IsNullOrEmpty(sortOrder) ? "CreditId" : "";
            ViewData["CreditAbrrev"] = sortOrder == "CreditAbrrev" ? "CreditAbrrev" : "CreditId";
            ViewData["CredirName"] = sortOrder == "CreditName" ? "CreditName" : "CreditId";
            ViewData["isSummer"] = sortOrder == "isSummer" ? "isSummer" : "CreditId";
            ViewData["isSpring"] = sortOrder == "isSpring" ? "isSpring" : "CreditId";
            ViewData["isFall"] = sortOrder == "isFall" ? "isFall" : "CreditId";
            var credits = from c in _context.Credits
                          select c;
            switch (sortOrder)
            {
                case "CreditId":
                    credits = credits.OrderBy(c => c.CreditId);
                    break;
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
        }

        // GET: Credits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var credit = await _context.Credits
                .FirstOrDefaultAsync(m => m.CreditId == id);
            if (credit == null)
            {
                return NotFound();
            }

            return View(credit);
        }

        // GET: Credits/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Credits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CreditId,CreditAbrrev,CreditName,isSummer,isSpring,isFall,Done")] Credit credit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(credit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(credit);
        }

        // GET: Credits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var credit = await _context.Credits.FindAsync(id);
            if (credit == null)
            {
                return NotFound();
            }
            return View(credit);
        }

        // POST: Credits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CreditId,CreditAbrrev,CreditName,isSummer,isSpring,isFall")] Credit credit)
        {
            if (id != credit.CreditId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(credit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CreditExists(credit.CreditId))
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
            return View(credit);
        }

        // GET: Credits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var credit = await _context.Credits
                .FirstOrDefaultAsync(m => m.CreditId == id);
            if (credit == null)
            {
                return NotFound();
            }

            return View(credit);
        }

        // POST: Credits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var credit = await _context.Credits.FindAsync(id);
            _context.Credits.Remove(credit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CreditExists(int id)
        {
            return _context.Credits.Any(e => e.CreditId == id);
        }
    }
}
