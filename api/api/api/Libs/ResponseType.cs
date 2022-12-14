using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace api.Libs;

public class ResponseType
{
  public static string GetMessageFormCode(HttpStatusCode code)
  {
    string? message = Enum.GetName(typeof(HttpStatusCode), code);
    if (message != null)
    {
      if (!message.Equals("OK"))
        message = Regex.Replace(message, "([A-Z])", " $1", RegexOptions.Compiled).Trim();
    }
    else
      message = "Unknown";

    return message;
  }
}
