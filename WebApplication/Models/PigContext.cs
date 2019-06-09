using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Models
{
    public class PigContext : DbContext
    {
        public DbSet<Pig> Pigs { get; set; }
        public PigContext(DbContextOptions<PigContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
