namespace api.Models;

public class OrderDetail : BaseEntity
{
  public Order Order { get; set; }

  public Product Product { get; set; }

  public int Quantity { get; set; }
}
