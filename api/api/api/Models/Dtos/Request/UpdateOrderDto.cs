namespace api.Models.Dtos.Request;

public class UpdateOrderDto
{
  public string OrderId { get; set; }

  public string Address { get; set; }

  public OrderType OrderType { get; set; }

  public OrderCompletedType OrderCompletionType { get; set; }

  public List<OrderItemDto> OrderItems { get; set; }
}
