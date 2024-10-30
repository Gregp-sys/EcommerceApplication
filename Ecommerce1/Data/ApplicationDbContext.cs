using Ecommerce1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce1.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUsers, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSets for various entities
        public DbSet<Product> Products { get; set; }
        public DbSet<Shopping_Session> ShoppingSessions { get; set; }
        public DbSet<Cart_item> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Details> OrderDetails { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Ignore properties to drop them from the database
            builder.Entity<AppUsers>()
               .HasKey(u => u.Id_Appuser); // Set custom primary key

            builder.Entity<AppUsers>()
                .Property(u => u.Id_Appuser)
                .ValueGeneratedOnAdd(); // Auto-increment for Id_Appuser

            // Ignore default Id from IdentityUser
            builder.Entity<AppUsers>()
                .Ignore(u => u.Id); // Ignore the default Id property

            // Additional configurations (e.g., ignoring security properties) can go here
           
            builder.Entity<AppUsers>().Ignore(u => u.ConcurrencyStamp);
            builder.Entity<AppUsers>().Ignore(u => u.AccessFailedCount);
            builder.Entity<AppUsers>().Ignore(u => u.LockoutEnabled);
            builder.Entity<AppUsers>().Ignore(u => u.TwoFactorEnabled);
            builder.Entity<AppUsers>().Ignore(u => u.PhoneNumber);
            builder.Entity<AppUsers>().Ignore(u => u.PhoneNumberConfirmed);
            builder.Entity<AppUsers>().Ignore(u => u.LockoutEnd);


            // Seed data for AppUsers


            // Discounts
            builder.Entity<Discount>().HasData(
                new Discount { Id_discount = 1, Name = "Fruit Discount", Description = "10% off all fruits", Percent = 10, Created = "2023-10-01 10:30:00", Modified = "2023-10-01 10:30:00" },
                new Discount { Id_discount = 2, Name = "Dairy Discount", Description = "15% off on dairy products", Percent = 15, Created = "2023-10-02 10:30:00", Modified = "2023-10-02 10:30:00" },
                new Discount { Id_discount = 3, Name = "Bakery Discount", Description = "Buy 2 Get 1 Free on bakery items", Percent = 5, Created = "2023-10-03 10:30:00", Modified = "2023-10-03 10:30:00" },
                new Discount { Id_discount = 4, Name = "Meat Discount", Description = "Buy 3 Get 1 Free on meat products", Percent = 10, Created = "2023-10-03 10:30:00", Modified = "2023-10-03 10:30:00" }
            );

            // Products
            builder.Entity<Product>().HasData(
                new Product { Id_product = 1, Name = "Apple", Description = "Fresh Red Apple", Price = 0.99m, SKU = "FRU-APL-001", Category = "Fruits", Created = "2023-10-01 10:30:00", Modified = "2023-10-05 14:20:00", Id_discount = 1 },
                new Product { Id_product = 2, Name = "Banana", Description = "Exotic Bananas", Price = 1.20m, SKU = "FRU-BAN-002", Category = "Fruits", Created = "2023-10-02 09:15:00", Modified = "2023-10-06 12:40:00", Id_discount = 1 },
                new Product { Id_product = 3, Name = "Carrot", Description = "Fresh Carrots", Price = 0.50m, SKU = "VEG-CAR-003", Category = "Vegetables", Created = "2023-10-03 11:30:00", Modified = "2023-10-07 09:00:00", Id_discount = null },
                new Product { Id_product = 4, Name = "Lemon", Description = "Fresh Lemon", Price = 2.50m, SKU = "VEG-TOM-004", Category = "Vegetables", Created = "2023-10-04 14:45:00", Modified = "2023-10-08 16:20:00", Id_discount = null },
                new Product { Id_product = 5, Name = "Milk", Description = "Whole Milk, 1 Gallon", Price = 3.99m, SKU = "DAR-MIL-005", Category = "Dairy", Created = "2023-10-05 08:30:00", Modified = "2023-10-09 15:35:00", Id_discount = 2 },
                new Product { Id_product = 6, Name = "Eggs", Description = "Dozen Organic Eggs", Price = 2.99m, SKU = "DAR-EGG-006", Category = "Dairy", Created = "2023-10-06 12:00:00", Modified = "2023-10-10 18:00:00", Id_discount = 2 },
                new Product { Id_product = 7, Name = "Bread", Description = "Whole Wheat Bread Loaf", Price = 2.50m, SKU = "BAK-BRD-007", Category = "Bakery", Created = "2023-10-07 07:50:00", Modified = "2023-10-11 12:15:00", Id_discount = 3 },
                new Product { Id_product = 8, Name = "Chicken Breast", Description = "Skinless Boneless Chicken Breast, 1 lb", Price = 4.99m, SKU = "MEA-CHK-008", Category = "Meat", Created = "2023-10-08 09:30:00", Modified = "2023-10-12 11:45:00", Id_discount = 4 }
            );

   
               
            
        }
    }
}
