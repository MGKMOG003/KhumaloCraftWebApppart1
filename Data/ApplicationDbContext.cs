using Microsoft.EntityFrameworkCore;
using KhumaloCraftWebApp.Models;

namespace KhumaloCraftWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, ProductName = "Handwoven Basket", Price = 250.00m, Category = "Home Decor", Availability = 0, Description = "Beautifully handwoven basket, perfect for storage or as a decorative piece.", Rating = 4.5f, SellerID = 1 },
                new Product { ProductID = 2, ProductName = "Decorative Pottery Vase", Price = 840.00m, Category = "Home Decor", Availability = 0, Description = "Elegant pottery vase, ideal for enhancing your home decor with a touch of tradition.", Rating = 5f, SellerID = 2 },
                new Product { ProductID = 3, ProductName = "Handcrafted Wooden Bowl", Price = 300.00m, Category = "Kitchenware", Availability = 10, Description = "Handcrafted wooden bowl, perfect for serving or as a rustic decorative piece.", Rating = 4.7f, SellerID = 3 },
                new Product { ProductID = 4, ProductName = "Beaded Jewelry Set", Price = 735.00m, Category = "Jewelry", Availability = 15, Description = "Exquisite beaded jewelry set, handcrafted to perfection for any occasion.", Rating = 5f, SellerID = 4 }
            );
        }
    }
}
