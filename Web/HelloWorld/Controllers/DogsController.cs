using System.Linq;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
namespace HelloWorld.Controllers
{
    public class DogsController : Controller
    {
        private DogsContext db;

        public DogsController(DogsContext context)
        {
            db = context;
        }

        [HttpGet]//запрос
        public IActionResult Dogs()
        {
            return View(db.Dogs.ToList());
        }

    }
}