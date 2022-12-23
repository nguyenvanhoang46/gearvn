using System.ComponentModel.DataAnnotations;

namespace api.Models.Dtos.Request;

public class CreateUserDto
{
  [Required] public string Username { get; set; }

  [Required] public string FirstName { get; set; }

  [Required] public string LastName { get; set; }

  [Required] public string PhoneNumber { get; set; }

  [Required] [EmailAddress] public string Email { get; set; }

  [Required] public string Password { get; set; }

  [Required] public UserRole Role { get; set; }
}
