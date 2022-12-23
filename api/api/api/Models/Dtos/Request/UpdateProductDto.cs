namespace api.Models.Dtos.Request;

public class UpdateProductDto
{
  public string Name { get; set; }

  public long Price { get; set; }

  public int Quantity { get; set; }

  public long? SalePrice { get; set; }

  public string Description { get; set; }

  public string Content { get; set; }

  public string? CategoryId { get; set; }

  public string? Id { get; set; }
}
