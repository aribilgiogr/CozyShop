using Core.Abstracts.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.Entities
{
    public class Shipment : BaseEntity
    {
        public virtual Order Order { get; set; }
        public string CarrierName { get; set; }
        public string TrackingNumber { get; set; }
        public string TrackingUrl { get; set; }
        public DateTime? ShippedAt { get; set; }
        public DateTime? DeliveredAt { get; set; }
        public DateTime? EstimatedDelivery { get; set; }
    }
}
