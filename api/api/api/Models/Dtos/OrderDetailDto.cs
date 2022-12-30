namespace api.Models.Dtos;

public class OrderDetailDto
{
  public string Id { get; set; } = Guid.NewGuid().ToString();

  public OrderDto Order { get; set; } = null!;

  public ProductDto Product { get; set; } = null!;

  public int Quantity { get; set; } = 0;
}
