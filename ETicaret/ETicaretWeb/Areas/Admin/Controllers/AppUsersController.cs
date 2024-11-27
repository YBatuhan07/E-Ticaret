﻿using ETicaretCore.Entities;
using ETicaretData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETicaretWeb.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(policy: "AdminPolicy")]
public class AppUsersController : Controller
{
    private readonly DataBaseContext _context;

    public AppUsersController(DataBaseContext context)
    {
        _context = context;
    }

    // GET: Admin/AppUsers
    [Authorize(policy: "CustomerPolicy")]
    public async Task<IActionResult> Index()
    {
        return View(await _context.AppUsers.ToListAsync());
    }

    // GET: Admin/AppUsers/Details/5
    [Authorize(policy: "CustomerPolicy")]
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var appUser = await _context.AppUsers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (appUser == null)
        {
            return NotFound();
        }

        return View(appUser);
    }

    // GET: Admin/AppUsers/Create
    [Authorize(policy: "CustomerPolicy")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(policy: "AdminPolicy")]
    public async Task<IActionResult> Create(AppUser appUser)
    {
        if (ModelState.IsValid)
        {
            _context.Add(appUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(appUser);
    }

    // GET: Admin/AppUsers/Edit/5
    [Authorize(policy: "CustomerPolicy")]
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var appUser = await _context.AppUsers.FindAsync(id);
        if (appUser == null)
        {
            return NotFound();
        }
        return View(appUser);
    }

    // POST: Admin/AppUsers/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(policy: "AdminPolicy")]
    public async Task<IActionResult> Edit(int id, AppUser appUser)
    {
        if (id != appUser.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(appUser);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppUserExists(appUser.Id))
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
        return View(appUser);
    }

    // GET: Admin/AppUsers/Delete/5
    [Authorize(policy: "CustomerPolicy")]
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var appUser = await _context.AppUsers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (appUser == null)
        {
            return NotFound();
        }

        return View(appUser);
    }

    // POST: Admin/AppUsers/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    [Authorize(policy: "AdminPolicy")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var appUser = await _context.AppUsers.FindAsync(id);
        if (appUser != null)
        {
            _context.AppUsers.Remove(appUser);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool AppUserExists(int id)
    {
        return _context.AppUsers.Any(e => e.Id == id);
    }
}
