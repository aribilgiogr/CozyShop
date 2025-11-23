using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Concrete.Entities
{
    public class Equipment
    {
        // Başka bir tabloyu anahtar olarak kullanabiliriz: one-2-one bağlantı.
        [Key, ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Material { get; set; }
        public string Dimensions { get; set; }
        public string Weight { get; set; }
        public string Capacity { get; set; }
        public string Color { get; set; }
        public int? WarrantyMonths { get; set; }
        public string Specifications { get; set; }
    }
}
