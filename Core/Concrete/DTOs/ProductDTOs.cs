using Core.Concrete.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Concrete.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductCount { get; set; }
    }

    public class ProductListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public decimal BasePrice { get; set; }
        public ProductType ProductType { get; set; }
        public decimal? DiscountedPrice { get; set; }
        public decimal? DiscountRate { get; set; }
        public string Cover { get; set; }
        public double? Rating { get; set; }
        public int ReviewCount { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool IsFeatured { get; set; }
    }

    public class ProductDetailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
        public decimal BasePrice { get; set; }
        public decimal? DiscountedPrice { get; set; }
        public decimal? DiscountRate { get; set; }
        public int StockQuantity { get; set; }
        public string SKU { get; set; }
        public CategoryDTO Category { get; set; }

        // Coffee Bean specific
        public CoffeeBeanDetailDTO CoffeeBean { get; set; }

        // Equipment specific
        public EquipmentDetailDTO Equipment { get; set; }

        // Reviews
        public double? Rating { get; set; }
        public int ReviewCount { get; set; }
        public List<ReviewDTO> RecentReviews { get; set; } = new List<ReviewDTO>();
    }

    public class CoffeeBeanDetailDTO
    {
        public bool IsGreenBean { get; set; }
        public RoastLevel? RoastLevel { get; set; }
        public ProcessMethod? ProcessMethod { get; set; }
        public string Variety { get; set; }
        public string HarvestYear { get; set; }
        public int? Acidity { get; set; }
        public int? Body { get; set; }
        public int? Sweetness { get; set; }
        public string FlavorNotes { get; set; }
        public string CuppingScore { get; set; }
        public OriginDTO Origin { get; set; }
    }

    public class EquipmentDetailDTO
    {
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

    public class OriginDTO
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Farm { get; set; }
        public string Altitude { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }

    public class ProductFilterDTO
    {
        public int? CategoryId { get; set; }
        public ProductType? ProductType { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public RoastLevel? RoastLevel { get; set; }
        public ProcessMethod? ProcessMethod { get; set; }
        public string OriginCountry { get; set; }
        public bool? InStockOnly { get; set; }
        public bool? FeaturedOnly { get; set; }
        public string SearchTerm { get; set; }
        public string SortBy { get; set; } // price_asc, price_desc, newest, popular, rating
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 12;
    }

    public class ProductSearchResultDTO
    {
        public IEnumerable<ProductListDTO> Products { get; set; } = new HashSet<ProductListDTO>();
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
        public bool HasPrevious => Page > 1;
        public bool HasNext => Page < TotalPages;
    }

    public class ReviewDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Rating { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsVerifiedPurchase { get; set; }
    }

    public class CreateReviewDTO
    {
        [Required]
        public int ProductId { get; set; }

        public int? OrderId { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 10)]
        public string Comment { get; set; }
    }
}
