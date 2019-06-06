using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    
    // [Route("api/[controller]")]
    [Route("api/Pistols")]
    public class PistolsApiController : Controller
    {
        private PistolsContext db;

        public PistolsApiController(PistolsContext context)
        {
            db = context;
        }

        // GET api/Pistols
        [HttpGet]
        public IEnumerable<Pistol> Get()
        {
            return db.Pistols.ToList();    
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Pistol Pistol = db.Pistols.FirstOrDefault(x => x.Id == id);
            if (Pistol == null)
                return NotFound();
            return new ObjectResult(Pistol);
        }

        [HttpDelete("{id}")]//удаление
        public IActionResult Delete(int id)
        {
        Pistol pistol = db.Pistols.FirstOrDefault(x => x.Id == id);
        if(pistol==null)
        {
        return NotFound();
            }
        db.Pistols.Remove(pistol);
        db.SaveChanges();
        return Ok(pistol);
        }
         [HttpPost]
        public void CreateBook([FromBody]Pistol pistol)
        {
            db.Pistols.Add(pistol);
            db.SaveChanges();
        }
    }
}