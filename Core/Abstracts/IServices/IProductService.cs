using Core.Concrete.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Abstracts.IServices
{
    public interface IProductService
    {
        // Product CRUD Operations
        ProductDetailDTO GetProductById(int id);
        ProductSearchResultDTO GetProducts(ProductFilterDTO filter);
        IEnumerable<ProductListDTO> GetFeaturedProducts(int count = 10);
        IEnumerable<ProductListDTO> GetNewArrivals(int count = 10);
        IEnumerable<ProductListDTO> GetBestSellers(int count = 10);
        IEnumerable<ProductListDTO> GetRelatedProducts(int productId, int count = 4);

        // Category Operations
        IEnumerable<CategoryDTO> GetAllCategories();
        CategoryDTO GetCategoryById(int id);
        IEnumerable<ProductListDTO> GetProductsByCategory(int categoryId, int page = 1, int pageSize = 12);

        // Review Operations
        IEnumerable<ReviewDTO> GetProductReviews(int productId, int page = 1, int pageSize = 10);
        ReviewDTO CreateReview(CreateReviewDTO review, int userId);
        bool CanUserReviewProduct(int userId, int productId);

        // Search Operations
        ProductSearchResultDTO SearchProducts(string searchTerm, int page = 1, int pageSize = 12);
        IEnumerable<ProductListDTO> GetProductsByOrigin(string country, int page = 1, int pageSize = 12);

        // Stock Operations
        bool CheckStockAvailability(int productId, int quantity);
        bool UpdateStock(int productId, int quantity);
    }
}