using Microsoft.EntityFrameworkCore;
namespace Pistol.Models
{
    public class PistolsContext : DbContext
    {
        public PistolsContext(DbContextOptions<PistolsContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Pistol> Pistol { get; set; }

    }
}