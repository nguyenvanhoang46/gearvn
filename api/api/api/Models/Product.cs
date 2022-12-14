using api.Models.Morph;

namespace api.Models;

public class Product : BaseEntity
{
  public string Name { get; set; }

  public long Price { get; set; }

  public int Quantity { get; set; }

  public long SalePrice { get; set; }

  public Category Category { get; set; }

  public ICollection<Image> Images { get; set; }
}
