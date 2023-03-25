using api.Models;
using api.Models.Dtos;
using AutoMapper;

namespace api.MapperProfiles;

public class OrderProfile : Profile
{
  public OrderProfile()
  {
    CreateMap<Order, OrderDto>()
      .ForMember(i => i.OrderDate, opt => opt.MapFrom(i => i.CreatedAt))
      .ForMember(d => d.User,
				o => o.MapFrom(
					(order, dto, dest, ctx) => ctx.Mapper.Map<UserDto>(order.User)
				)
			);
  }
}
