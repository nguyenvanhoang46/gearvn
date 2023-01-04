using api.Models;
using api.Models.Dtos;
using AutoMapper;

namespace api.MapperProfiles;

public class UserProfile : Profile
{
  public UserProfile()
  {
    CreateMap<User, UserDto>()
      .ForMember(d => d.FirstName, o => o.MapFrom(s => s.FirstName))
      .ForMember(d => d.LastName, o => o.MapFrom(s => s.LastName))
      .ForMember(d => d.FullName,
        o => o.MapFrom(s => $"{s.FirstName} {s.LastName}"))
      .ForMember(d => d.Email,
        o => o.MapFrom(s => s.Email))
      .ForMember(d => d.Phone,
        o => o.MapFrom(s => s.PhoneNumber))
      .ForMember(d => d.Id
        , o => o.MapFrom(s => s.Id)).ReverseMap();
  }
}
