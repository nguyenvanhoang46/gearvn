using System.Security.Claims;
using api.Models;
using api.Models.Dtos.Request;
using api.Models.Dtos.Response;
using Microsoft.AspNetCore.Identity;

namespace api.Repository.IRepo;

public interface IUserRepo
{
  public Task<IdentityResult> RegisterAsync(RegisterDto model);
  public Task<TokenDto?> LoginAsync(LoginDto model);
  public Task<bool> RevokeAll();
  public Task<User?> FindByEmail(string email);
  public Task<List<User>> FindAll();
  public Task<User?> GetMe(ClaimsPrincipal user);
  public Task<bool> UpdateAsync(User user);
  public Task<List<string>?> GetRoleByUser(User user);
}
