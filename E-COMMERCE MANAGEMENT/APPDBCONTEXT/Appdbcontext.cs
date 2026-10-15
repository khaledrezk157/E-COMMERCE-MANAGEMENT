using E_COMMERCE_MANAGEMENT.MOdels;
using Microsoft.EntityFrameworkCore;

namespace E_COMMERCE_MANAGEMENT.APPDBCONTEXT
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> Items { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(a => a.orders)
                .WithOne(a => a.users)
                .HasForeignKey(a => a.UserId);
           
            modelBuilder.Entity<Product>()
                .HasMany(a=>a.orderItems)
                .WithOne(a => a.products)
                .HasForeignKey(a => a.ProductId);
          
            
            modelBuilder.Entity<Category>()
                .HasMany(a=>a.products)
                .WithOne(a=>a.category)
                .HasForeignKey(a=>a.categoryId);

            modelBuilder.Entity<Product>()
                 .HasMany(a => a.orderItems)
                 .WithOne(a => a.products)
                 .HasForeignKey(a => a.OrderId);

          modelBuilder.Entity<Category>()
                .HasIndex(a=>a.Name)
                .IsUnique();

            modelBuilder.Entity<User>()
               .HasIndex(a => a.Email)
               .IsUnique();

            //////dataseding
            modelBuilder.Entity<User>().HasData(
              new User { ID=1,FullName= "Ahmed Hassan",Email= "ahmed@example.com",Password= "123456A",Role= "Customer" },
              new User { ID=2,FullName= "Mona Ali", Email= "mona@example.com", Password= "123456M",Role= "Customer" },
              new User { ID=3,FullName= "Store Admin", Email= "admin@example.com", Password= "123456Adm",Role= "Admin" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1,Name= "Electronics", Description= "Electronic devices and accessories", },  
                new Category { Id=2,Name= "Books", Description= "Programming and technical books", },
                new Category { Id=3,Name= "Accessories", Description= "Everyday computer accessories", }
                   );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id=1,Name= "Wireless Mouse", Price=450,StockQuantity=25,categoryId=1,},
                new Product { Id=5,Name= "Wireless kibord", Price=400,StockQuantity=20,categoryId=1,},
                new Product { Id=2,Name= "Headphones", Price=1200,StockQuantity=12,categoryId=2,},
                new Product { Id=3,Name= "C++ Fundamentals", Price=350,StockQuantity=30,categoryId=3,}
            );
            modelBuilder.Entity<Order>().HasData(
                new Order { Id=1,orderDate=new DateTime(2026 , 10 , 01),Status= "Completed", TotalAmount=800,UserId=1},
                new Order { Id=2,orderDate=new DateTime(2026, 10, 10),Status= "Pending", TotalAmount=1200,UserId=2},
                new Order { Id=3,orderDate=new DateTime(2026, 10, 12),Status= "Cancelled", TotalAmount=350,UserId=3}
                );
            modelBuilder.Entity<OrderItem>().HasData(
                
                new OrderItem { Id = 1, Quantity = 1, UniteOfPrice = 450, OrderId = 1, ProductId = 1 },
                new OrderItem { Id=2,Quantity=1,UniteOfPrice=350,OrderId=2,ProductId=2},
                new OrderItem { Id=3,Quantity=1,UniteOfPrice=1200,OrderId=3,ProductId=3}
                );

        }
    }
}
