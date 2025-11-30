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

        public IEnumerable<string> GetAllOriginCountries()
        {
            return GetAllOrigins().Select(x => x.Country).Distinct();
        }

        public IEnumerable<OriginDTO> GetAllOrigins()
        {
            using (IUnitOfWork uow = new UnitOfWork())
            {
                var origins = uow.OriginRepository.Find(x => x.Active && !x.Deleted);
                return AutoMapperConfig.Mapper.Map<IEnumerable<OriginDTO>>(origins);
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
            using (IUnitOfWork uow = new UnitOfWork())
            {
                var featured_products = uow.ProductRepository.Find(x => x.IsFeatured && x.Active && !x.Deleted, "Category", "Reviews")
                                                             .OrderByDescending(x => x.CreatedAt)
                                                             .Take(count);

                return AutoMapperConfig.Mapper.Map<IEnumerable<ProductListDTO>>(featured_products);
            }
        }

        public IEnumerable<ProductListDTO> GetNewArrivals(int count = 10)
        {
            using (IUnitOfWork uow = new UnitOfWork())
            {
                var new_products = uow.ProductRepository.Find(x => x.Active && !x.Deleted, "Category", "Reviews")
                                                        .OrderByDescending(x => x.CreatedAt)
                                                        .Take(count);

                return AutoMapperConfig.Mapper.Map<IEnumerable<ProductListDTO>>(new_products);
            }
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
            using (IUnitOfWork uow = new UnitOfWork())
            {
                var result = new ProductSearchResultDTO();
                if (filter == null) filter = new ProductFilterDTO();

                var query = uow.ProductRepository.Find(x => x.Active && !x.Deleted, "Category", "CoffeeBean", "Equipment", "Reviews");
                // Filtering
                if (filter.CategoryId.HasValue)
                {
                    query = query.Where(x => x.CategoryId == filter.CategoryId.Value);
                }

                if (filter.ProductType.HasValue)
                {
                    query = query.Where(x => x.ProductType == filter.ProductType.Value);
                }

                if (filter.MinPrice.HasValue)
                {
                    query = query.Where(x => x.BasePrice >= filter.MinPrice.Value);
                }

                if (filter.MaxPrice.HasValue)
                {
                    query = query.Where(x => x.BasePrice <= filter.MaxPrice.Value);
                }

                if (filter.FeaturedOnly.HasValue)
                {
                    query = query.Where(x => x.IsFeatured == filter.FeaturedOnly.Value);
                }

                if (filter.InStockOnly.HasValue)
                {
                    query = query.Where(x => x.StockQuantity > 0);
                }

                if (query.Count() > 0)
                {
                    result.TotalCount = query.Count();
                    // Pagination
                    query = query.OrderByDescending(x => x.CreatedAt)
                             .Skip((filter.Page - 1) * filter.PageSize)
                             .Take(filter.PageSize);

                    result.Products = AutoMapperConfig.Mapper.Map<IEnumerable<ProductListDTO>>(query);
                }

                return result;
            }

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
