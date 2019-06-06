using System.Linq;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
namespace HelloWorld.Controllers
{
    public class PistolsController : Controller
    {
        private PistolsContext db;

        public PistolsController(PistolsContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Pistols()
        {
            return View(db.Pistols.ToList());
        }

    }
}