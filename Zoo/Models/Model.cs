using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Zoo.Models
{
    public class AnimalsContext : DbContext
    {
        public AnimalsContext(DbContextOptions<AnimalsContext> options)
            : base(options)
        { }

        public DbSet<Animal> Animals { get; set; }
    }

    public class Animal
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
    }
}