using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.DTOs
{
    public class CartDTO
    {
        public int Id { get; set; }
        public List<CartItemDTO> Items { get; set; } = new List<CartItemDTO>();
        public decimal SubTotal => Items.Sum(i => i.TotalPrice);
        public int TotalItems => Items.Sum(i => i.Quantity);
        public int ItemCount => Items.Count();
    }

    public class CartItemDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice => UnitPrice * Quantity;
        public bool IsInStock { get; set; }
    }

    public class AddToCartDTO
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; } = 1;
    }
}
