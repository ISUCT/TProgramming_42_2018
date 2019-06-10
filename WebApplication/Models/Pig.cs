using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Pig
    {
        //общая логика которая будет в базе данных, т.е. определяет столбцы в БД 
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    
        public int Price { get; set; }
    }
}
