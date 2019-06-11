using Microsoft.EntityFrameworkCore;
//Чтобы взаимодействовать с базой данных через Entity Framework нам нужен контекст данных - класс, 
//унаследованный от класса Microsoft.EntityFrameworkCore.DbContext. 

namespace FoxApp.Models
{
    public class FoxxContext : DbContext 
    {
        public DbSet<Fox> Foxes { get; set; } //Свойство DbSet представляет собой коллекцию объектов, 
                                              //которая сопоставляется с определенной таблицей в базе данных. 
                                              //При этом по умолчанию название свойства должно соответствовать множественному числу
                                              //названию модели в соответствии с правилами английского языка. 
        public FoxxContext(DbContextOptions<FoxxContext> options)
            : base(options) //Через параметр options в конструктор контекста данных будут передаваться настройки контекста.
        {
            Database.EnsureCreated(); //В конструкторе с помощью вызова Database.EnsureCreated() 
                                      //по определению моделей будет создаваться база данных
        }
    }
}