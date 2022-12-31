using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;
using api.Filters;
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
  public Task<User?> FindById(string id);

  public Task<bool> CreateUser(CreateUserDto dto);
  public Task<bool> UpdateUser(UpdateUserDto dto, string id);
  public Task<bool> DeleteUser(string id);

  public Task<string> GetRoleByUserId(string id);

  IEnumerable<User> Paginate(out int totalRecords, PaginationFilter? paginationFilter = null,
    Expression<Func<User, bool>>? predicate = null, string? relations = "", string? orderByQueryString = "");
}
