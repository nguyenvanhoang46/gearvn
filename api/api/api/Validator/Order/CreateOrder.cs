using api.Models.Dtos.Request;
using FluentValidation;

namespace api.Validator.Order;

public class CreateOrder : AbstractValidator<CreateOrderDto>
{
  public CreateOrder()
  {
    RuleFor(c => c.UserId).NotEmpty();
  }
}
