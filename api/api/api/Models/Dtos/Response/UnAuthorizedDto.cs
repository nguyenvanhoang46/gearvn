using System.Net;

namespace api.Models.Dtos.Response;

public class UnAuthorizedDto
{
  public HttpStatusCode statusCode { get; set; } = HttpStatusCode.Unauthorized;

  public string message { get; set; } = "Unauthorized";
}
