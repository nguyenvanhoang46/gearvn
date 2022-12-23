namespace api.Models;

public enum OrderType
{
  Completed,
  Pending,
}

public class Order : BaseEntity
{
  public User User { get; set; }

  public OrderType OrderType { get; set; } = OrderType.Pending;

  public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
