namespace api.Models.Dtos;

public class OrderDto
{
  public string Id { get; set; } = Guid.NewGuid().ToString();

  public DateTime OrderDate { get; set; } = DateTime.Now;

  public UserDto User { get; set; } = new UserDto();

  public ICollection<OrderDetailDto> OrderItems { get; set; } = new List<OrderDetailDto>();

  public long TotalPrice => OrderItems.Sum(x =>
    x.Product.Price > x.Product.SalePrice ? x.Product.SalePrice : x.Product.Price * x.Quantity);
}
