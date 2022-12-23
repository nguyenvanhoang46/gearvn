using api.Models.Dtos.Request;
using FluentValidation;

namespace api.Validator.Order;

public class CreateOrder : AbstractValidator<CreateOrderDto>
{
  public CreateOrder()
  {
    RuleFor(c => c.CustomerName).NotEmpty();
    RuleFor(c => c.CustomerEmail).NotEmpty();
    RuleFor(c => c.CustomerAddress).NotEmpty();
    RuleFor(c => c.CustomerPhone).NotEmpty();
    RuleFor(c => c.UserId).NotEmpty();
  }
}
