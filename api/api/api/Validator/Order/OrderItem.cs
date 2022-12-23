using api.Models.Dtos.Request;
using FluentValidation;

namespace api.Validator.Order;

public class OrderItem : AbstractValidator<OrderItemDto>
{
  public OrderItem()
  {
    
  }
}
