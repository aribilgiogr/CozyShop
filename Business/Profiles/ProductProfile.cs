using AutoMapper;
using Core.Concrete.DTOs;
using Core.Concrete.Entities;
using System.Linq;

namespace Business.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Category, CategoryDTO>()
                .ForMember(dest => dest.ProductCount, opt => opt.MapFrom(src => src.Products.Count));

            CreateMap<Product, ProductListDTO>()
                .ForMember(d => d.DiscountedPrice, o => o.MapFrom(s => s.BasePrice * (100 - s.DiscountRate) / 100))
                .ForMember(d => d.CategoryName, o => o.MapFrom(s => s.Category.Name))
                .ForMember(d => d.ReviewCount, o => o.MapFrom(s => s.Reviews.Count))
                .ForMember(d => d.Rating, o => o.MapFrom(s => s.Reviews.Any() ? s.Reviews.Average(r => r.Rating) : 0));

            CreateMap<Origin, OriginDTO>();
        }
    }
}
