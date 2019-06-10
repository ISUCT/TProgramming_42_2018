using Microsoft.EntityFrameworkCore;

namespace FoxApp.Models
{
    public class FoxxContext : DbContext
    {
        public DbSet<Fox> Foxes { get; set; }
        public FoxxContext(DbContextOptions<FoxxContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}