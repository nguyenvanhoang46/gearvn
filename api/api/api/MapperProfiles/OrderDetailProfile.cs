using api.Models;
using api.Models.Dtos;
using AutoMapper;

namespace api.MapperProfiles;

public class OrderDetailProfile : Profile
{
  public OrderDetailProfile()
  {
    CreateMap<OrderDetail, OrderDetailDto>()
      .ForMember(d => d.Product,
        o => o.MapFrom(
          (order, dto, dest, ctx) => ctx.Mapper.Map<ProductDto>(order.Product!)
        )
      )
      .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
      // .ForMember(dest => dest.Order, opt => opt.MapFrom(src => src.Order))
      .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
      .ReverseMap();
  }
}
