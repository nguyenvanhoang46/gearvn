using Microsoft.AspNetCore.Identity;

namespace api.Models;

public enum UserRole
{
  Admin,
  User,
  Guest
}

public class Role : IdentityRole
{
  public bool IsDeleted { get; set; }
}
