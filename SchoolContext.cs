using Microsoft.EntityFrameworkCore;

namespace EfMigrate
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;Database=testef;User Id=root;Password=root;");
        }
    }
}
