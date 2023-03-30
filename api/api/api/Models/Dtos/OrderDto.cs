namespace api.Models.Dtos;

public class OrderDto
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    
    public string Address { get; set; }
    
    public string City { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;

    public Product Product { get; set; }
    public UserDto User { get; set; } = new UserDto();
    public ICollection<OrderDetailDto>? OrderItems { get; set; } = new List<OrderDetailDto>();


    public long TotalPrice => OrderItems.Sum(x =>
        x.Product.Price > x.Product.SalePrice ? x.Product.SalePrice : x.Product.Price * x.Quantity);
}