using System;
using System.Collections.Generic;
using System.Linq;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HelloWorld.Controllers
{

    
    // [Route("api/[controller]")]
    [Route("api/Dogs")]
    public class DogsApiController : Controller
    {
        private DogsContext db;

        public DogsApiController(DogsContext context)
        {
            db = context;
        }

        // GET api/Dogs
        [HttpGet]
        public IEnumerable<Dog> Get()
        {
            return db.Dogs.ToList();    
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Dog Dog = db.Dogs.FirstOrDefault(x => x.Id == id);
            if (Dog == null)
                return NotFound();
            return new ObjectResult(Dog);
        }
        
        //удаление 


        [HttpDelete("{id}")] //запрос
public  IActionResult Delete(int? id)
{
    if (id != null)
    {
        Dog dog =  db.Dogs.FirstOrDefault(p => p.Id == id);
        if (dog != null)
        {
            db.Dogs.Remove(dog);
             db.SaveChanges();
        return RedirectToAction("Dogs");
        }
    }
    return NotFound();
}
    }
}
