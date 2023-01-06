using api.Models;
using api.Models.Dtos;
using api.Models.Dtos.Request;
using AutoMapper;

namespace api.MapperProfiles;

public class CategoryProfile : Profile
{
  public CategoryProfile()
  {
    CreateMap<Category, CategoryDto>()
      .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
      .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
      .ReverseMap();

    CreateMap<Category, UpdateCategoryDto>()
      .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
      .ReverseMap();
  }
}
