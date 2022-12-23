using api.Models.Dtos.Request;
using FluentValidation;

namespace api.Validator.Auth;

public class RefreshToken : AbstractValidator<RefreshTokenDto>
{
  public RefreshToken()
  {
    RuleFor(x => x.Token).NotEmpty();
    RuleFor(x => x.RefreshToken).NotEmpty();
  }
}
