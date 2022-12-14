namespace api.Models.Dtos;

public class UserDto
{
  public string Id { get; set; } = Guid.NewGuid().ToString();

  public string Email { get; set; } = string.Empty;

  public string FullName { get; set; } = string.Empty;

  public string Phone { get; set; } = string.Empty;
}
