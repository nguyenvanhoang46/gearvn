using api.Models;
using api.Models.Dtos;
using AutoMapper;

namespace api.MapperProfiles;

public class OrderDetailProfile : Profile
{
  private readonly IMapper _mapper;

  public OrderDetailProfile(IMapper mapper)
  {
    _mapper = mapper;

    CreateMap<OrderDetail, OrderDetailDto>()
      .ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product))
      .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
      .ForMember(dest => dest.Order, opt => opt.MapFrom(src => _mapper.Map<Order, OrderDto>(src.Order)))
      .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
      .ReverseMap();
  }
}
