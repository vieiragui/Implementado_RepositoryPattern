using Microsoft.EntityFrameworkCore;
using TestandoRepositoryPattern.Model;

namespace TestandoRepositoryPattern.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}