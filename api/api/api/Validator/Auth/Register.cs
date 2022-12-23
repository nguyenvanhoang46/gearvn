using api.Models.Dtos.Request;
using FluentValidation;

namespace api.Validator.Auth;

public class Register : AbstractValidator<RegisterDto>
{
  public Register()
  {
    RuleFor(x => x.Email).NotEmpty().EmailAddress();
    RuleFor(x => x.Password)
      .NotEmpty()
      .MinimumLength(6);
    RuleFor(x => x.ConfirmPassword).NotEmpty().Equal(x => x.Password);
  }
}
