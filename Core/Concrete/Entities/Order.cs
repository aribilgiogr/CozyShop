using Core.Abstracts.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util.Enums;

namespace Core.Concrete.Entities
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public decimal SubTotal { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string CouponCode { get; set; }
        public string Notes { get; set; }
        public string ShippingFullName { get; set; }
        public string ShippingPhone { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingDistrict { get; set; }
        public string ShippingAddressLine { get; set; }
        public string ShippingPostalCode { get; set; }

        public virtual Shipment Shipment { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
    }
}
