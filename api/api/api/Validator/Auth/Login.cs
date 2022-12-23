using api.Models.Dtos.Request;
using FluentValidation;

namespace api.Validator.Auth;

public class Login : AbstractValidator<LoginDto>
{
  public Login()
  {
    RuleFor(x => x.Email).NotEmpty().EmailAddress();
    RuleFor(x => x.Password).NotEmpty();
  }
}
