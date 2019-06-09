using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private PigContext db;

        public HomeController(PigContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Pigs.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Pig Pig)
        {
            db.Pigs.Add(Pig);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id != null)
            {
                Pig Pig = await db.Pigs.FirstOrDefaultAsync(p => p.Id == id);

                if (Pig != null)
                    return View(Pig);

            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Pig Pig)
        {
            db.Pigs.Update(Pig);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Pig Pig = await db.Pigs.FirstOrDefaultAsync(p => p.Id == id);
                if (Pig != null)
                    return View(Pig);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Pig Pig = await db.Pigs.FirstOrDefaultAsync(p => p.Id == id);
                if (Pig != null)
                {
                    db.Pigs.Remove(Pig);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }

            return NotFound();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
