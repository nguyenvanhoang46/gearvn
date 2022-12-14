using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace api.Models.Dtos.Response;

public class CustomException : ActionFilterAttribute
{
  public override void OnActionExecuting(ActionExecutingContext context)
  {
    if (!context.ModelState.IsValid)
    {
      var errors = context.ModelState.Values
        .Where(v => v.Errors.Count > 0)
        .SelectMany(v => v.Errors)
        .Select(v => new { Message = v.ErrorMessage })
        .ToList();


      var responseObj = new
      {
        statusCode = HttpStatusCode.BadRequest,
        message = "Validation error",
        data = new { },
        errors
      };

      context.Result = new JsonResult(responseObj)
      {
        StatusCode = 200
      };
    }
  }
}
