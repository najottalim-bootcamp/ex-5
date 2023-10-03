using Microsoft.EntityFrameworkCore;

namespace exfive.Data
{
    public class AppDbContext : DbContext
    {
        string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=salom;Database=RegisterDb";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<DishIngredient>().HasNoKey();
            base.OnModelCreating(modelBuilder);
        }
    }
}
