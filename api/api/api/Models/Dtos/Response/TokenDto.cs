namespace api.Models.Dtos.Response;

public class TokenDto
{
  public string? AccessToken { get; set; }

  public string? RefreshToken { get; set; }

  public DateTime? TokenExpires { get; set; }
}
