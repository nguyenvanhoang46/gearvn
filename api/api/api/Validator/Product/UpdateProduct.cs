using api.Models.Dtos.Request;
using FluentValidation;

namespace api.Validator.Product;

public class UpdateProduct : AbstractValidator<UpdateProductDto>
{
  public UpdateProduct()
  {
  }
}
