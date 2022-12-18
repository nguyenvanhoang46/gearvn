using System.Security.Claims;
using api.Context;
using api.Models;
using api.Models.Dtos.Request;
using api.Models.Dtos.Response;
using api.Repository.IRepo;
using api.Services.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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
}
