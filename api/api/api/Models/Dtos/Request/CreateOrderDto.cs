namespace api.Models.Dtos.Request;

public class CreateOrderDto
{
  public string UserId { get; set; }

  public string CustomerName { get; set; }

  public string CustomerEmail { get; set; }

  public string CustomerAddress { get; set; }

  public string CustomerPhone { get; set; }
}
