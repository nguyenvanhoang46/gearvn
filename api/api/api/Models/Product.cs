using api.Models.Morph;

namespace api.Models;

public class Product : BaseEntity
{
  public string Name { get; set; }

  public long Price { get; set; } = 0;

  public int Quantity { get; set; } = 1;

  public long SalePrice { get; set; } = 0;

  public string Description { get; set; } = string.Empty;

  public string Content { get; set; } = string.Empty;

  public Category? Category { get; set; } = null;

  public ICollection<Image>? Images { get; set; } = null;
}
