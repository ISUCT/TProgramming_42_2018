using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Models
{
    /*здесь  определим контекст данных*/
    public class PigContext : DbContext
    {
        public DbSet<Pig> Pigs { get; set; }
        public PigContext(DbContextOptions<PigContext> options)
            : base(options)
        {
            Database.EnsureCreated();//метод создавающий базу данных , если ее нет , а если есть то метод не работает
        }
    }
}

