namespace api.Models;

public class Order : BaseEntity
{
  public User User;
  public List<OrderDetail> OrderDetails;
}
