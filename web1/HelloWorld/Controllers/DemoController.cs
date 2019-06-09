namespace HelloWorld.Controllers
{
    using System.Linq;
    using HelloWorld.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
using System.Text;
using Microsoft.EntityFrameworkCore;
    /*При получении запроса система маршрутизации выбирает для обработки запроса нужный контроллер и передает ему
     данные запроса. Контроллер обрабатывает эти данные и посылает обратно результат обработки. */

    public class DemoController : Controller
    {
         private PigsContext db;

         public DemoController(PigsContext context)
        {
            db = context;
        }

         [HttpGet]
        public IActionResult Pigs()
        {
            return View(db.Pigs.ToList());
        }

        public string Dummy(int id)
        {
            return $"id++={id + 1}";
        }

        public string RequestDummy()
        {
            int id = int.Parse(Request.Query.FirstOrDefault(p => p.Key == "id").Value);
            return $"id++={id + 1}";
        }
 //удаление 
       [HttpGet]
[ActionName("Delete")]
public async Task<IActionResult> ConfirmDelete(int? id)
{
    if (id != null)
    {
        Pig pig = await db.Pigs.FirstOrDefaultAsync(p => p.Id == id);
        if (pig != null)
            return View(pig);
    }
    return NotFound();
}
 
[HttpPost]
public async Task<IActionResult> Delete(int? id)
{
    if (id != null)
    {
        Pig pig = await db.Pigs.FirstOrDefaultAsync(p => p.Id == id);
        if (pig != null)
        {
            db.Pigs.Remove(pig);
            await db.SaveChangesAsync();
            return RedirectToAction("Pigs");
        }
    }
    return NotFound();
}
//редактирование
public async Task<IActionResult> Edit(int? id)
{
    if(id!=null)
    {
        Pig pig = await db.Pigs.FirstOrDefaultAsync(p=>p.Id==id);
        if (pig != null)
            return View(pig);
    }
    return NotFound();
}
[HttpPost]
public async Task<IActionResult> Edit(Pig pig)
{
    db.Pigs.Update(pig);
    await db.SaveChangesAsync();
    return RedirectToAction("Pigs");
}
//добавление
  public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Pig pig)
        {
            db.Pigs.Add(pig);
            await db.SaveChangesAsync();
            return RedirectToAction("Pigs");
        }
     

    }
}