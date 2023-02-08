namespace api.Models.Dtos.Request;

public class CreateOrderDto
{
    public string UserId { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public List<OrderItemDto> OrderItems { get; set; }
}
