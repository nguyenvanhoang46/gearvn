namespace api.Models.Dtos.Request;

public class DeleteImageDto
{
  public ImageFor ImageFor { get; set; }

  public string Id { get; set; }

  public List<string> ImageIds { get; set; }
}
