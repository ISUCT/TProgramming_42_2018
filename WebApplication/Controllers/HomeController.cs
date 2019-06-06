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
        private TelevisionContext db;

        public HomeController(TelevisionContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Televisions.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Television television)
        {
            db.Televisions.Add(television);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id != null)
            {
                Television television = await db.Televisions.FirstOrDefaultAsync(p => p.Id == id);

                if (television != null)
                    return View(television);

            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Television television)
        {
            db.Televisions.Update(television);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Television television = await db.Televisions.FirstOrDefaultAsync(p => p.Id == id);
                if (television != null)
                    return View(television);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Television television = await db.Televisions.FirstOrDefaultAsync(p => p.Id == id);
                if (television != null)
                {
                    db.Televisions.Remove(television);
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
