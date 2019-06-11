using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoxApp.Models; 

namespace FoxApp.Controllers
{
    public class HomeController : Controller
    {
        private FoxxContext db;  //Для взаимодействия с базой данных в контроллере определяется переменная контекст
                                 //данных FoxxContext db. Причем поскольку в классе Startup в методе ConfigureServices 
                                 //контекст данных устанавливается как сервис, то в конструкторе контроллера мы можем 
                                 //получить переданный контекст данных.
        public HomeController(FoxxContext context)
        {
            db = context;
        }
        //Создание
        public async Task<IActionResult> Index()
        {
            return View(await db.Foxes.ToListAsync()); // Получаем объекты из бд, создаём из них список и передаём в представление.
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Fox fox)
        {
            db.Foxes.Add(fox);
            await db.SaveChangesAsync(); //Добавление данных в базу
            return RedirectToAction("Index");
        }
        //Детали
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Fox fox = await db.Foxes.FirstOrDefaultAsync(p => p.Id == id); //Метод получает id объекта, 
                                                                               //о котором надо вывести информацию. 
                                                                            //Затем найденный объект передается в представление. 
                if (fox != null)
                    return View(fox);
            }
            return NotFound();
        }
        //Редактирование
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Fox fox = await db.Foxes.FirstOrDefaultAsync(p => p.Id == id);
                if (fox != null)
                    return View(fox);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Fox fox)
        {
            db.Foxes.Update(fox);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        //Удаление
        [HttpGet]
        [ActionName("Delete")] //Данный атрибут указывает, что этот метод также относится к действию Delete
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Fox fox = await db.Foxes.FirstOrDefaultAsync(p => p.Id == id);
                if (fox != null)
                    return View(fox);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Fox fox = new Fox { Id = id.Value };
                db.Entry(fox).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
    }
