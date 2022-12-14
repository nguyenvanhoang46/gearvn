using System.Security.Claims;
using api.Models;

namespace api.Services.IServices;

public interface IJwtService
{
  public string GenerateToken(User model, List<string>? roles = null);
  public string GenerateRefreshToken();
  public ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token);
}
