using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util.Enums;

namespace Core.Concrete.DTOs
{
    public class CreateOrderDTO
    {
        [Required]
        public int ShippingAddressId { get; set; }
        [Required]
        public PaymentMethod PaymentMethod { get; set; }
        public string CouponCode { get; set; }
        public string Notes { get; set; }
    }

    public class OrderDTO
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public OrderStatus Status { get; set; }
        public string StatusText { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public AddressDTO ShippingAddress { get; set; }
        public List<OrderItemDTO> Items { get; set; } = new List<OrderItemDTO>();
        public ShipmentDTO Shipment { get; set; }
    }

    public class OrderListDTO
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public OrderStatus Status { get; set; }
        public string StatusText { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ItemCount { get; set; }
        public string FirstProductImageUrl { get; set; }
    }

    public class OrderItemDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }

    public class OrderHistoryDTO
    {
        public List<OrderListDTO> Orders { get; set; } = new List<OrderListDTO>();
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
    }

    public class PaymentDTO
    {
        public int Id { get; set; }
        public PaymentMethod Method { get; set; }
        public PaymentStatus Status { get; set; }
        public decimal Amount { get; set; }
        public string TransactionId { get; set; }
        public DateTime? PaidAt { get; set; }
    }

    public class ShipmentDTO
    {
        public int Id { get; set; }
        public string CarrierName { get; set; }
        public string TrackingNumber { get; set; }
        public string TrackingUrl { get; set; }
        public DateTime? ShippedAt { get; set; }
        public DateTime? DeliveredAt { get; set; }
        public DateTime? EstimatedDelivery { get; set; }
    }

    public class ValidateCouponDto
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public decimal OrderAmount { get; set; }
    }

    public class CouponValidationResultDto
    {
        public bool IsValid { get; set; }
        public string Message { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal FinalAmount { get; set; }
    }
}
