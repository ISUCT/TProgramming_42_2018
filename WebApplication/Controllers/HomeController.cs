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
    /*При получении запроса система маршрутизации выбирает для обработки запроса нужный контроллер и передает ему данные запроса. 
    Контроллер обрабатывает эти данные и посылает обратно результат обработки. */
    public class HomeController : Controller
    {
        /*Далее идет подключение базы , что бы к ней можно было обратиться из контролера */
        private PigContext db;

        public HomeController(PigContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Pigs.ToListAsync());//помещение элементов БД на страницу 
        }

        public IActionResult Create()//метод добавления в БД
        {
            return View();
        }

        [HttpPost]//пример типа запроса 
        public async Task<IActionResult> Create(Pig Pig)
        {
            db.Pigs.Add(Pig);//добавление в бд
            await db.SaveChangesAsync();//сохранение изменения бд
            return RedirectToAction("Index");//возврат в начало
        }

        public async Task<IActionResult> Edit(int? id)//метод изменения, сначало он возвращает нужный экземпляр из бд
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
        public async Task<IActionResult> Edit(Pig Pig)//тепер передает изменения
        {
            db.Pigs.Update(Pig);//обнавление экземпляра
            await db.SaveChangesAsync();//сохранение
            return RedirectToAction("Index");//возврат
        }

        [HttpGet]
        [ActionName("Delete")]//означает что к методу ConfirmDelete можно обратиться по имени Delete
        public async Task<IActionResult> ConfirmDelete(int? id)//получение данных из бд, для отрисовки 
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
        public async Task<IActionResult> Delete(int? id)//изменение данных
        {
            if (id != null)
            {
                Pig Pig = await db.Pigs.FirstOrDefaultAsync(p => p.Id == id);
                if (Pig != null)//проверка на существование
                {
                    db.Pigs.Remove(Pig);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }

            return NotFound();
        }

      //  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]//кэширование
        public IActionResult Error()//метод для error
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });//возврат ошибки по соответствующей модели
        }
    }
}
