using Microsoft.EntityFrameworkCore;
using ProdutApp.Domain.Entities;
using System;

namespace ProductApp.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
              new Product() { Id = Guid.NewGuid(), Name = "Pen", Value = 10, Quantity = 100 },
              new Product() { Id = Guid.NewGuid(), Name = "Papter a4", Value = 45, Quantity = 4 },
              new Product() { Id = Guid.NewGuid(), Name = "book", Value = 1, Quantity = 10 }
                              );
            base.OnModelCreating(modelBuilder);
        }

    }
}
