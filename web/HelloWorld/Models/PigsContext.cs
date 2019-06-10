using Microsoft.EntityFrameworkCore;
namespace HelloWorld.Models
{
    public class PigsContext : DbContext
    {
        public PigsContext(DbContextOptions<PigsContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Pig> Pigs { get; set; }

    }
}