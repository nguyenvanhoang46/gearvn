using api.Models.Dtos.Request;
using FluentValidation;

namespace api.Validator.Category;

public class UpdateCategory : AbstractValidator<UpdateCategoryDto>
{
  public UpdateCategory()
  {
  }
}
