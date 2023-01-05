using System.ComponentModel.DataAnnotations;

namespace api.Models.Dtos.Request;

public class UpdateUserDto
{
  public string? FirstName { get; set; }

  public string? LastName { get; set; }

  public string? PhoneNumber { get; set; }

  public string? Email { get; set; }

  public string? Password { get; set; }

  public UserRole? Role { get; set; }
}
