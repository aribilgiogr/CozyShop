using Core.Abstracts.Bases;
using Core.Concrete.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Cover { get; set; }
        public ProductType ProductType { get; set; }
        public decimal BasePrice { get; set; }
        public decimal? DiscountRate { get; set; }
        public int StockQuantity { get; set; } = 0;
        public string SKU { get; set; }
        public bool IsFeatured { get; set; } = false;
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
        public virtual CoffeeBean CoffeeBean { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
    }
}
