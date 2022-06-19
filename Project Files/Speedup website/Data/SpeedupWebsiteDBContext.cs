using Microsoft.EntityFrameworkCore;
using Speedup_website.Entitys;
using Speedup_website.Entitys.People;
using Speedup_website.Entitys.Products;
using Speedup_website.Entitys.Orders;

namespace Speedup_website.Data
{
    public class SpeedupWebsiteDBContext : DbContext
    {
        public SpeedupWebsiteDBContext(DbContextOptions<SpeedupWebsiteDBContext> options) : base(options)
        {

        }

        //Speedup_website.Entitys.People
        public DbSet<User> Users { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<CashingType> CashingTypes { get; set; }
        public DbSet<UserPayment> UserPayments { get; set; }
        public DbSet<OwnerCashingOut> OwnerCashingOuts { get; set; }

        //Speedup_website.Entitys.Products
        public DbSet<Product> Products { get; set; }
        public DbSet<Catigory> Catigories { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        //Speedup_website.Entitys.Orders
        public DbSet<ShoppingSassion> ShoppingSassions { get; set; }
        public DbSet<GuestShoppingSession> GuestShoppingSessions { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<GuestCartItem> GuestCartItems { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }
        public DbSet<Discount> Discounts { get; set; }

        //Speedup_website.Entitys
        public DbSet<ModifyingDetails> ModifyingDetails { get; set; }
    }
}