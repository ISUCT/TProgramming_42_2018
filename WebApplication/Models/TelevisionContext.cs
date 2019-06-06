using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Models
{
    public class TelevisionContext : DbContext
    {
        public DbSet<Television> Televisions { get; set; }
        public TelevisionContext(DbContextOptions<TelevisionContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
