using api.Models.Dtos.Request;
using FluentValidation;

namespace api.Validator.User;

public class CreateUser : AbstractValidator<CreateUserDto>
{
  public CreateUser()
  {
    RuleFor(c => c.Username).NotEmpty().WithMessage("Username is required");
    RuleFor(c => c.Password).NotEmpty().WithMessage("Password is required");
  }
}
