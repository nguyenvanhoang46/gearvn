using System.Security.Claims;

namespace api.Libs;

public class UserExtension
{
  public static class ClaimsPrincipalExtensions
  {
    public static string GetUserId(ClaimsPrincipal principal)
    {
      if (principal == null)
      {
        throw new ArgumentNullException(nameof(principal));
      }

      var claim = principal.FindFirst(ClaimTypes.NameIdentifier);
      return claim != null ? claim.Value : null;
    }
  }
}
