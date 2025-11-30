using Core.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Web.Models
{
    public class ShopIndexViewModel
    {
        public IEnumerable<CategoryDTO> Categories { get; set; } = new HashSet<CategoryDTO>();
        public IEnumerable<string> OriginCountries { get; set; } = new HashSet<string>();
        public ProductSearchResultDTO SearchResult { get; set; }
    }
}