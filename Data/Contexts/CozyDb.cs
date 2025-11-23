using Core.Concrete.Entities;
using System.Data.Entity;

namespace Data.Contexts
{
    public class CozyDb : DbContext
    {
        public CozyDb() : base("name=shopdb")
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Origin> Origins { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CoffeeBean> CoffeeBeans { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
    }
}
