using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace api.Models;

public class User : IdentityUser
{
  public string FirstName { get; set; }

  public string LastName { get; set; }

  public string? RefreshToken { get; set; }

  public DateTime RefreshTokenExpiryTime { get; set; }
}
