using Microsoft.EntityFrameworkCore;
using WebApplication9.Data.Entities;

namespace WebApplication9.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
