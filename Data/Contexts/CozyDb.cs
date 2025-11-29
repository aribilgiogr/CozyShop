using Core.Concrete.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace Data.Contexts
{
    public class CozyDb : DbContext
    {
        public CozyDb() : base("name=shopdb")
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Origin> Origins { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<CoffeeBean> CoffeeBeans { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
    }
}
