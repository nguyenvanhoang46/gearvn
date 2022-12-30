using System.ComponentModel.DataAnnotations;

namespace api.Models.Dtos.Request;

public class OrderItemDto
{
  [Required] public string ProductId { get; set; }

  public int Quantity { get; set; } = 1;
}
