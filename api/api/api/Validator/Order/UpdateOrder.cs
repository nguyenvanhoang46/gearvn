using api.Models.Dtos.Request;
using FluentValidation;

namespace api.Validator.Order;

public class UpdateOrder : AbstractValidator<UpdateOrderDto>
{
  public UpdateOrder()
  {
  }
}
