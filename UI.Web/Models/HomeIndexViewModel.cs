using Core.Concrete.DTOs;
using System.Collections.Generic;

namespace UI.Web.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<ProductListDTO> FeaturedProducts { get; set; } = new HashSet<ProductListDTO>();
        public IEnumerable<ProductListDTO> NewArrivals { get; set; } = new HashSet<ProductListDTO>();
        public IEnumerable<CategoryDTO> NewCategories { get; set; } = new HashSet<CategoryDTO>();

    }
}