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

        // OnModelCreating metodu, Entity Framework'te veritabanı modelinin nasıl oluşturulacağını yapılandırmak için kullanılır
        // Bu metod DbContext sınıfından override edilerek özelleştirilir
        // Veritabanı şeması oluşturulmadan önce, EF bu metodu çağırarak model yapılandırmasını alır
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder parametresi, entity'ler arasındaki ilişkileri, tablo isimlerini,
            // primary key'leri, foreign key'leri ve diğer veritabanı kısıtlamalarını tanımlamak için kullanılır

            // Order ve Payment arasında 1:0..1 (bire sıfır veya bir) ilişkisi kuruluyor
            // Payment tablosunda OrderId foreign key olarak ekleniyor
            // Bir siparişin ödeme bilgisi olabilir veya olmayabilir
            modelBuilder.Entity<Order>().HasOptional(o => o.Payment).WithRequired(p => p.Order).Map(m => m.MapKey("OrderId"));

            // Order ve Shipment arasında 1:0..1 (bire sıfır veya bir) ilişkisi kuruluyor
            // Shipment tablosunda OrderId foreign key olarak ekleniyor
            // Bir siparişin kargo bilgisi olabilir veya olmayabilir
            modelBuilder.Entity<Order>().HasOptional(o => o.Shipment).WithRequired(s => s.Order).Map(m => m.MapKey("OrderId"));

            // Bu metod içinde yapılan tüm yapılandırmalar, Data Annotations (attribute'lar) yerine
            // Fluent API kullanılarak yapılır ve daha esnek yapılandırma imkanı sağlar
        }
    }
}
