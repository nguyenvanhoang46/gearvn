namespace api.Models;

public class OrderDetail : BaseEntity
{
  public Order Order;
  public Product Product;
  public int Quantity;
}
