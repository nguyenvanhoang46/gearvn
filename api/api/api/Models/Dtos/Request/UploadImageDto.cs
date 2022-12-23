namespace api.Models.Dtos.Request;

public enum ImageFor
{
  Product,
  Category,
  User,
}

public class UploadImageDto
{
  public List<IFormFile> Image { get; set; }

  public ImageFor ImageFor { get; set; }

  public string Id { get; set; }
}
