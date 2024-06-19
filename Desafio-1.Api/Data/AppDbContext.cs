using Desafio_1.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Desafio_1.Api.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Product> Products => Set<Product>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Product>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Name = "Notebook",
                        Price = 2900.99m,
                        QuantityStock = 100
                    },
                    new
                    {
                        Id = 2,
                        Name = "Mouse",
                        Price = 49.99m,
                        QuantityStock = 200
                    },
                    new
                    {
                        Id = 3,
                        Name = "Teclado",
                        Price = 109.97m,
                        QuantityStock = 150
                    },
                    new
                    {
                        Id = 4,
                        Name = "Monitor",
                        Price = 999.99m,
                        QuantityStock = 50
                    },
                    new
                    {
                        Id = 5,
                        Name = "Tablet",
                        Price = 1200.99m,
                        QuantityStock = 75
                    }
                );
        }
    }
}
