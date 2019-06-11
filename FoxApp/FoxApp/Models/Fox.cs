using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxApp.Models
{
    public class Fox //Модель, представляющая объекты, которые будут храниться в базе данных.
    {
        public int Id { get; set; }
        public string Name { get; set; } // имя
        public string Breed { get; set; } // вид
        public string Description { get; set; } // описание
        public int Age { get; set; } //возраст
    }
}
