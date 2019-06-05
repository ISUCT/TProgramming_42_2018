using System;
using System.Collections.Generic;
using System.Linq;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Text;

//using System.Data.Entity;

namespace HelloWorld.Controllers
{
    
    // [Route("api/[controller]")]
    [Route("api/Pigs")]
    public class PigsApiController : Controller
    {
        private PigsContext db;

        public PigsApiController(PigsContext context)
        {
            db = context;
        }

        // GET api/Pigs
        [HttpGet]
        public IEnumerable<Pig> Get()
        {
            return db.Pigs.ToList();    
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Pig Pig = db.Pigs.FirstOrDefault(x => x.Id == id);
            if (Pig == null)
                return NotFound();
            return new ObjectResult(Pig);
        }
        //удаление 
       
        [HttpPost]
public  IActionResult Delete(int? id)
{
    if (id != null)
    {
        Pig pig =  db.Pigs.FirstOrDefault(p => p.Id == id);
        if (pig != null)
        {
            db.Pigs.Remove(pig);
             db.SaveChanges();
           // return RedirectToActionResult("Index");
        }
    }
    return NotFound();
}
      //редоктирование

       
    }
}