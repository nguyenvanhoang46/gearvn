using api.Models.Dtos.Request;
using FluentValidation;

namespace api.Validator.Category;

public class CreateCategory : AbstractValidator<CreateCategoryDto>
{
  public CreateCategory()
  {
  }
}
