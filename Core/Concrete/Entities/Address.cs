using Core.Abstracts.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.Entities
{
    public class Address : BaseEntity
    {
        [Required]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string District { get; set; }
        public string Neighborhood { get; set; }
        [Required]
        public string AddressLine { get; set; }
        public string PostalCode { get; set; }
        public bool IsDefault { get; set; } = false;
    }
}
