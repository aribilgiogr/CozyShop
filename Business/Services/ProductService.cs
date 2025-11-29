using Core.Abstracts.IServices;
using Core.Concrete.DTOs;
using System;
using System.Collections.Generic;

namespace Business.Services
{
    public class ProductService : IProductService
    {
        public bool CanUserReviewProductAsync(int userId, int productId)
        {
            throw new NotImplementedException();
        }

        public bool CheckStockAvailabilityAsync(int productId, int quantity)
        {
            throw new NotImplementedException();
        }

        public ReviewDTO CreateReviewAsync(CreateReviewDTO review, int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDTO> GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductListDTO> GetBestSellersAsync(int count = 10)
        {
            throw new NotImplementedException();
        }

        public CategoryDTO GetCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductListDTO> GetFeaturedProductsAsync(int count = 10)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductListDTO> GetNewArrivalsAsync(int count = 10)
        {
            throw new NotImplementedException();
        }

        public ProductDetailDTO GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReviewDTO> GetProductReviewsAsync(int productId, int page = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        public ProductSearchResultDTO GetProductsAsync(ProductFilterDTO filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductListDTO> GetProductsByCategoryAsync(int categoryId, int page = 1, int pageSize = 12)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductListDTO> GetProductsByOriginAsync(string country, int page = 1, int pageSize = 12)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductListDTO> GetRelatedProductsAsync(int productId, int count = 4)
        {
            throw new NotImplementedException();
        }

        public ProductSearchResultDTO SearchProductsAsync(string searchTerm, int page = 1, int pageSize = 12)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStockAsync(int productId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
