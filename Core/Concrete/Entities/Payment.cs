using Core.Abstracts.Bases;
using System;
using System.ComponentModel.DataAnnotations;
using Util.Enums;

namespace Core.Concrete.Entities
{
    public class Payment : BaseEntity
    {
        public virtual Order Order { get; set; }
        public PaymentMethod Method { get; set; }
        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
        public decimal Amount { get; set; }
        public string TransactionId { get; set; }
        public string GatewayResponse { get; set; }
        public DateTime? PaidAt { get; set; }
    }
}
