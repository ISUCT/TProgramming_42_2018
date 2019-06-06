using Microsoft.EntityFrameworkCore;
namespace HelloWorld.Models
{
    public class PistolsContext : DbContext
    {
        public PistolsContext(DbContextOptions<PistolsContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Pistol> Pistols { get; set; }

    }
}