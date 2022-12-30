using api.Models;
using api.Models.Dtos;
using AutoMapper;

namespace api.MapperProfiles;

public class OrderProfile : Profile
{
  private readonly IMapper _mapper;

  public OrderProfile(IMapper mapper)
  {
    _mapper = mapper;
    CreateMap<Order, OrderDto>()
      .ForMember(i => i.OrderDate, opt => opt.MapFrom(i => i.CreatedAt))
      .ForMember(i => i.User, otp => otp.MapFrom(i => _mapper.Map<User, UserDto>(i.User)));
  }
}
