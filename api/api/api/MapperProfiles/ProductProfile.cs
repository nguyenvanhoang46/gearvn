using api.Models;
using api.Models.Dtos;
using AutoMapper;

namespace api.MapperProfiles;

public class ProductProfile : Profile
{
  public ProductProfile()
  {
    CreateMap<Product, ProductDto>()
      .ForMember(d => d.MainImage,
        o => o.MapFrom(s => s.Images.FirstOrDefault()!.Url))
      .ForMember(d => d.Images,
        o => o.MapFrom(s => s.Images.Select(i => i.Url)))
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
  }
}
