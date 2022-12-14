using Microsoft.AspNetCore.Identity;

namespace api.Models;

public class Role : IdentityRole
{
  public bool IsDelete { get; set; }
}
