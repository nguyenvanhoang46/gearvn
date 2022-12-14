using System.Net;

namespace api.Models.Dtos.Response;

public class ForbiddenDto
{
  public HttpStatusCode statusCode { get; set; } = HttpStatusCode.Forbidden;

  public string message { get; set; } = "Forbidden";
}
