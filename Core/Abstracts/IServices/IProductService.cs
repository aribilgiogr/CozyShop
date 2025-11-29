using Core.Concrete.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Abstracts.IServices
{
    public interface IProductService
    {
        // Product CRUD Operations
        ProductDetailDTO GetProductByIdAsync(int id);
        ProductSearchResultDTO GetProductsAsync(ProductFilterDTO filter);
        IEnumerable<ProductListDTO> GetFeaturedProductsAsync(int count = 10);
        IEnumerable<ProductListDTO> GetNewArrivalsAsync(int count = 10);
        IEnumerable<ProductListDTO> GetBestSellersAsync(int count = 10);
        IEnumerable<ProductListDTO> GetRelatedProductsAsync(int productId, int count = 4);

        // Category Operations
        IEnumerable<CategoryDTO> GetAllCategoriesAsync();
        CategoryDTO GetCategoryByIdAsync(int id);
        IEnumerable<ProductListDTO> GetProductsByCategoryAsync(int categoryId, int page = 1, int pageSize = 12);

        // Review Operations
        IEnumerable<ReviewDTO> GetProductReviewsAsync(int productId, int page = 1, int pageSize = 10);
        ReviewDTO CreateReviewAsync(CreateReviewDTO review, int userId);
        bool CanUserReviewProductAsync(int userId, int productId);

        // Search Operations
        ProductSearchResultDTO SearchProductsAsync(string searchTerm, int page = 1, int pageSize = 12);
        IEnumerable<ProductListDTO> GetProductsByOriginAsync(string country, int page = 1, int pageSize = 12);

        // Stock Operations
        bool CheckStockAvailabilityAsync(int productId, int quantity);
        bool UpdateStockAsync(int productId, int quantity);
    }
}