namespace api.Models.Dtos;

public class CategoryDto
{
  public string Id { get; set; } = Guid.NewGuid().ToString();

  public string Name { get; set; } = string.Empty;

  public ICollection<ProductDto> Products { get; set; } = new List<ProductDto>();
}
