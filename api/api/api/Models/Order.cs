namespace api.Models;

public enum OrderType
{
  Completed,
  Pending,
}

public enum OrderCompletedType
{
  Inventory,
  Complete,
}

public class Order : BaseEntity
{
  public User User { get; set; }

  public string Address { get; set; }

  public OrderType OrderType { get; set; } = OrderType.Pending;

  public OrderCompletedType OrderCompletionType { get; set; } = OrderCompletedType.Inventory;

  public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
