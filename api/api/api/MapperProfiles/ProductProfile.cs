using api.Models;
using api.Models.Dtos;
using api.Models.Dtos.Request;
using AutoMapper;

namespace api.MapperProfiles;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductDto>()
          .ForMember(d => d.MainImage,
            o => o.MapFrom((x, x1, x2, x3) => x3.Mapper.Map<ImageDto>(x.Images!.FirstOrDefault())))
          .ForMember(d => d.Images,
            o => o.MapFrom((x, x1, x2, x3) => x3.Mapper.Map<List<ImageDto>>(x.Images)))
          .ForMember(d => d.Category,
            o => o.MapFrom(s => s.Category))
          .ForMember(d => d.SalePrice,
            o => o.MapFrom(s => s.SalePrice))
          .ForMember(d => d.Quantity, o => o.MapFrom(s => s.Quantity))
          .ForMember(d => d.Price, o => o.MapFrom(s => s.Price))
          .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
          .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
          .ForMember(d => d.Description, o => o.MapFrom(s => s.Description))
          .ForMember(d => d.Content, o => o.MapFrom(s => s.Content));

        CreateMap<UpdateProductDto, Product>()
          .ForMember(d => d.CategoryId,
            o => o.MapFrom(s => s.CategoryId))
          .ForMember(d => d.SalePrice,
            o => o.MapFrom(s => s.SalePrice))
          .ForMember(d => d.Quantity, o => o.MapFrom(s => s.Quantity))
          .ForMember(d => d.Price, o => o.MapFrom(s => s.Price))
          .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
          .ForMember(d => d.Description, o => o.MapFrom(s => s.Description))
          .ForMember(d => d.Content, o => o.MapFrom(s => s.Content))
          .ReverseMap()
          .ForAllMembers(d => d.Condition(s => s != null));
    }
}
