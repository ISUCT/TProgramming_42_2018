using System.Collections.Generic;
using System.Linq;
using Pistol.Models;
using Microsoft.AspNetCore.Mvc;

namespace Pistol.Controllers
{
    
    // [Route("api/[controller]")]
    [Route("api/pistols")]
    
    public class PistolsApiController : Controller
    {
        private PistolsContext db;

        public PistolsApiController(PistolsContext context)
        {
            db = context;
        }

        // GET api/pistols
        [HttpGet]
        public IEnumerable <Pistol> Get()
        {
            return db.Pistols.ToList();    
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Pistol pistol = db.Pistols.FirstOrDefault(x => x.Id == id);
            if (pistol == null)
            return NotFound();
            return new ObjectResult(pistol);
        }

    }
}