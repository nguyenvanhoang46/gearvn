using System.ComponentModel.DataAnnotations;

namespace api.Models.Dtos.Request;

public class RegisterDto
{
  [Required] public string Username { get; set; }

  [Required] public string FirstName { get; set; }

  [Required] public string LastName { get; set; }

  [Required] public string PhoneNumber { get; set; }

  [Required] [EmailAddress] public string Email { get; set; }

  [Required] public string Password { get; set; }

  [Required] [Compare("Password")] public string ConfirmPassword { get; set; }
}
