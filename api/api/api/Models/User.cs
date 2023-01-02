using Microsoft.AspNetCore.Identity;

namespace api.Models;

public class User : IdentityUser
{
  public string FirstName { get; set; }

  public string LastName { get; set; }

  public string? RefreshToken { get; set; }

  public bool IsDeleted { get; set; } = false;

  public DateTime RefreshTokenExpiryTime { get; set; }
}
