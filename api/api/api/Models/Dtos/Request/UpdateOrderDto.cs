namespace api.Models.Dtos.Request;

public class UpdateOrderDto
{
  public string OrderId { get; set; }

  public List<OrderItemDto> OrderItems { get; set; }
}
