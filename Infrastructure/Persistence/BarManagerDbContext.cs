using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class BarManagerDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Receipt> Receipts { get; set; }

        public BarManagerDbContext(DbContextOptions<BarManagerDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrderItem>()
                .HasKey(o => o.ItemId);

            modelBuilder.Entity<Table>()
                .HasKey(o => o.TableNumber);

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Latte", Price = 12.5m, Category = Domain.Enums.Category.HotDrinks },
                new Product { ProductId = 2, ProductName = "Burger", Price = 25m, Category = Domain.Enums.Category.Other },
                new Product { ProductId = 3, ProductName = "Cheesecake", Price = 18m, Category = Domain.Enums.Category.Other }
            );

            //modelBuilder.Entity<Table>().HasData(
            //    new Table { TableNumber = 1, Status = Domain.Enums.Status.Pending },
            //    new Table { TableNumber = 2, Status = Domain.Enums.Status.Pending }
            //);
        }
    }
}
