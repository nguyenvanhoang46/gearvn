using System.Security.Claims;
using api.Context;
using api.Models;
using api.Models.Dtos.Request;
using api.Models.Dtos.Response;
using api.Repository.IRepo;
using api.Services.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;

namespace api.Repository;

public class UserRepo : IUserRepo
{
  private readonly AppDbContext _context;
  private readonly UserManager<User> _userManager;
  private readonly SignInManager<User> _signInManager;
  private readonly IJwtService _jwtUtils;
  private readonly IConfiguration _configuration;

  public UserRepo(
    AppDbContext context,
    UserManager<User> userManager,
    SignInManager<User> signInManager,
    IJwtService jwtUtils,
    IConfiguration configuration)
  {
    _context = context;
    _userManager = userManager;
    _signInManager = signInManager;
    _configuration = configuration;
    _jwtUtils = jwtUtils;
  }

  public async Task<IdentityResult> RegisterAsync(RegisterDto model)
  {
    var user = new User()
    {
      Email = model.Email,
      UserName = model.Username,
      FirstName = model.FirstName,
      LastName = model.LastName,
      PhoneNumber = model.PhoneNumber,
    };

    return await _userManager.CreateAsync(user, model.Password);
  }


  public async Task<bool> UpdateUser(UpdateUserDto dto, string id)
  {
    User? user = await _userManager.FindByIdAsync(id);

    if (user != null)
    {
      user.UserName = dto.Username ?? user.UserName;
      user.Email = dto.Email ?? user.Email;
      user.FirstName = dto.FirstName ?? user.FirstName;
      user.LastName = dto.LastName ?? user.LastName;
      user.PhoneNumber = dto.PhoneNumber ?? user.PhoneNumber;

      var result = await _userManager.UpdateAsync(user);

      if (!result.Succeeded) return result.Succeeded;

      await _userManager.RemoveFromRolesAsync(user, await _userManager.GetRolesAsync(user));

      var resultRole = await _userManager.AddToRoleAsync(user, dto.Role.GetDisplayName());

      return resultRole.Succeeded;
    }

    return false;
  }

  public async Task<bool> DeleteUser(string id)
  {
    User? user = _userManager.FindByIdAsync(id).Result;
    if (user == null) return false;
    var result = await _userManager.DeleteAsync(user);
    return result.Succeeded;
  }

  public async Task<bool> CreateUser(CreateUserDto dto)
  {
    IdentityRole? role = await _context.Roles.FirstOrDefaultAsync(r => r.Name == dto.Role.GetDisplayName());

    User user = new User
    {
      UserName = dto.Username,
      Email = dto.Email,
      FirstName = dto.FirstName,
      LastName = dto.LastName,
      PhoneNumber = dto.PhoneNumber,
    };

    await _userManager.CreateAsync(user, dto.Password);

    var result = await _userManager.AddToRoleAsync(user, role!.Name);

    if (result.Succeeded)
    {
      return true;
    }

    return false;
  }

  public async Task<TokenDto?> LoginAsync(LoginDto model)
  {
    var user = await _userManager.FindByEmailAsync(model.Email);
    if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
    {
      List<string>? roles = await _userManager.GetRolesAsync(user) as List<string>;

      string token = _jwtUtils.GenerateToken(user, roles);
      string refreshToken = _jwtUtils.GenerateRefreshToken();
      _ = int.TryParse(_configuration["JWT:RefreshTokenExpiresDays"], out int refreshTokenValidityInDays);

      user.RefreshToken = refreshToken;
      user.RefreshTokenExpiryTime = DateTime.Now.AddDays(refreshTokenValidityInDays);
      await _userManager.UpdateAsync(user);

      return new TokenDto
      {
        AccessToken = token,
        RefreshToken = refreshToken
      };
    }

    return null;
  }

  public async Task<bool> RevokeAll()
  {
    try
    {
      var users = await _userManager.Users.ToListAsync();
      foreach (var user in users)
      {
        user.RefreshToken = null;
        await _userManager.UpdateAsync(user);
      }

      return true;
    }
    catch (Exception e)
    {
      return false;
    }
  }

  public async Task<User?> FindByEmail(string email)
  {
    return await _userManager.FindByEmailAsync(email);
  }

  public async Task<List<string>?> GetRoleByUser(User user)
  {
    return await _userManager.GetRolesAsync(user) as List<string>;
  }

  public int Count()
  {
    return _userManager.Users.Count();
  }

  public async Task<bool> UpdateAsync(User user)
  {
    try
    {
      await _userManager.UpdateAsync(user);
      return true;
    }
    catch (Exception e)
    {
      return false;
    }
  }

  public async Task<List<User>> FindAll()
  {
    return await _userManager.Users.ToListAsync();
  }

  public async Task<User?> GetMe(ClaimsPrincipal user)
  {
    string email = user.FindFirst(ClaimTypes.Email)!.Value;
    var getUser = await _userManager.FindByEmailAsync(email);
    return getUser;
  }

  public async Task<User> FindById(string id)
  {
    return await _userManager.FindByIdAsync(id);
  }
}
