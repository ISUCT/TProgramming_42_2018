using System.Linq;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
namespace HelloWorld.Controllers
{
    public class PigsController : Controller
    {
        private PigsContext db;

        public PigsController(PigsContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Pigs()
        {
            return View(db.Pigs.ToList());
        }

    }
}