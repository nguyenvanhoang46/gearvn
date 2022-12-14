using api.Models.Morph;

namespace api.Models.Dtos;

public class ProductDto
{
  public string Id { get; set; } = Guid.NewGuid().ToString();

  public string Name { get; set; } = null!;

  public long Price { get; set; } = 0;

  public int Quantity { get; set; } = 0;

  public long SalePrice { get; set; } = 0;

  public Category Category { get; set; } = null!;

  public ICollection<ImageDto> Images { get; set; } = null!;

  public ImageDto MainImage { get; set; } = null!;
}
