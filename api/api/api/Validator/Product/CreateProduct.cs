using api.Models.Dtos.Request;
using FluentValidation;

namespace api.Validator.Product;

public class CreateProduct : AbstractValidator<CreateProductDto>
{
  public CreateProduct()
  {

  }
}
