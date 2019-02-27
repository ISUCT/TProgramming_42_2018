using System.Data.Entity;
  
namespace WebAPI.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}