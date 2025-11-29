using AutoMapper;
using Core.Concrete.DTOs;
using Core.Concrete.Entities;

namespace Business.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Category, CategoryDTO>().ForMember(dest => dest.ProductCount, opt => opt.MapFrom(src => src.Products.Count));
        }
    }
}
