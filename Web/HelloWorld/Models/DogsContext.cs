using Microsoft.EntityFrameworkCore;
namespace HelloWorld.Models
{
    public class DogsContext : DbContext
    {
        public DogsContext(DbContextOptions<DogsContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Dog> Dogs { get; set; }

    }
}