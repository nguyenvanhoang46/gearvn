using api.Models.Dtos;
using api.Models.Morph;
using AutoMapper;

namespace api.MapperProfiles;

public class ImageProfile : Profile
{
  public ImageProfile()
  {
    CreateMap<Image, ImageDto>()
      .ForMember(i => i.Url, opt => opt.MapFrom(i => i.Url))
      .ForMember(i => i.MineType, opt => opt.MapFrom(i => i.MimeType))
      .ForMember(i => i.Alt, opt => opt.MapFrom(i => i.Alt))
      .ReverseMap();
  }
}
