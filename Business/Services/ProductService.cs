using AutoMapper;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Core.Concrete.DTOs;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class ProductService : IProductService
    {
        public bool CanUserReviewProduct(int userId, int productId)
        {
            throw new NotImplementedException();
        }

        public bool CheckStockAvailability(int productId, int quantity)
        {
            throw new NotImplementedException();
        }

        public ReviewDTO CreateReview(CreateReviewDTO review, int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDTO> GetAllCategories()
        {
            using (IUnitOfWork uow = new UnitOfWork())
            {
                // Aktif ve silinmemiş kategorileri getirsin.
                var categories = uow.CategoryRepository.Find(x => x.Active && !x.Deleted, "Products");

                //return categories.Select(x => new CategoryDTO
                //{
                //    Id = x.Id,
                //    Name = x.Name,
                //    Description = x.Description,
                //    ProductCount = x.Products.Count()
                //});

                return AutoMapperConfig.Mapper.Map<IEnumerable<CategoryDTO>>(categories);
            }
        }

        public IEnumerable<ProductListDTO> GetBestSellers(int count = 10)
        {
            throw new NotImplementedException();
        }

        public CategoryDTO GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductListDTO> GetFeaturedProducts(int count = 10)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductListDTO> GetNewArrivals(int count = 10)
        {
            throw new NotImplementedException();
        }

        public ProductDetailDTO GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReviewDTO> GetProductReviews(int productId, int page = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        public ProductSearchResultDTO GetProducts(ProductFilterDTO filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductListDTO> GetProductsByCategory(int categoryId, int page = 1, int pageSize = 12)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductListDTO> GetProductsByOrigin(string country, int page = 1, int pageSize = 12)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductListDTO> GetRelatedProducts(int productId, int count = 4)
        {
            throw new NotImplementedException();
        }

        public ProductSearchResultDTO SearchProducts(string searchTerm, int page = 1, int pageSize = 12)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStock(int productId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
