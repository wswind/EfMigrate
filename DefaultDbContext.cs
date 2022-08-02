using Microsoft.EntityFrameworkCore;

namespace EfMigrate
{
    public class DefaultDbContext : DbContext
    {
        //public DbSet<> Entities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;Database=efmig;User Id=root;Password=root;");
        }
    }
}