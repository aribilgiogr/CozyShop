using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.DTOs
{
    public class AddressDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        //Müşteri tablosundan gelen bilgiler
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Neighborhood { get; set; }
        public string AddressLine { get; set; }
        public string PostalCode { get; set; }
        public bool IsDefault { get; set; }
    }

    public class CreateAddressDTO
    {
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
        public bool IsDefault { get; set; }
    }

    public class UpdateAddressDTO
    {
        public int Id { get; set; }
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
        public bool IsDefault { get; set; }
    }
}
