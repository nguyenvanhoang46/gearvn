using System.Linq.Expressions;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using api.Context;
using api.Filters;
using api.Models;
using api.Models.Dtos.Request;
using api.Models.Dtos.Response;
using api.Repository.IRepo;
using api.Services.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;
using System.Linq.Dynamic.Core;

namespace api.Repository;

public class UserRepo : IUserRepo
{
  private readonly AppDbContext _context;
  private readonly UserManager<User> _userManager;
  private readonly SignInManager<User> _signInManager;
  private readonly IJwtService _jwtUtils;
  private readonly IConfiguration _configuration;
  private readonly DbSet<User> _dbSet;

  public UserRepo(
    AppDbContext context,
    UserManager<User> userManager,
    SignInManager<User> signInManager,
    IJwtService jwtUtils,
    IConfiguration configuration,
    DbSet<User> dbSet
  )
  {
    _dbSet = dbSet;
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
    if (result.Succeeded)
      return true;
    throw new AggregateException(result.Errors.Select(e => new Exception(e.Description)));
  }

  public IEnumerable<User> Paginate(out int totalRecords, PaginationFilter? paginationFilter = null,
    Expression<Func<User, bool>>? predicate = null, string? relations = "", string? orderByQueryString = "")
  {
    IQueryable<User> query = _dbSet;
    query = GetRelations(query, relations);

    if (predicate != null)
    {
      query = query.Where(predicate);
      totalRecords = query.Count();
    }

    totalRecords = query.Count();

    query = GetSorting(query, orderByQueryString);

    if (paginationFilter != null)
    {
      query = query.Skip((paginationFilter.PageNumber - 1) * paginationFilter.PageSize)
        .Take(paginationFilter.PageSize);
    }

    return query.ToList();
  }

  private IQueryable<User> GetRelations(IQueryable<User> query, string? relations = "")
  {
    if (string.IsNullOrEmpty(relations)) return query;

    IQueryable<User> newQuery = query;

    foreach (var prop in relations.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
    {
      newQuery = newQuery.Include(prop);
    }

    return newQuery;
  }

  private IQueryable<User> GetSorting(IQueryable<User> query, string? orderByQueryString = "")
  {
    if (string.IsNullOrEmpty(orderByQueryString)) return query;

    IQueryable<User> newQuery = query;

    var orderParams = orderByQueryString.Trim().Split(',');
    var propertyInfos = typeof(User).GetProperties(BindingFlags.Public | BindingFlags.Instance);
    var orderQueryBuilder = new StringBuilder();

    foreach (var param in orderParams)
    {
      if (string.IsNullOrWhiteSpace(param)) continue;
      var propertyFromQueryName = param.StartsWith('-') ? param.Split("-")[1] : param;
      var objectProperty = propertyInfos.FirstOrDefault(pi =>
        pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

      if (objectProperty == null) continue;

      var direction = param.StartsWith("-") ? "descending" : "ascending";
      orderQueryBuilder.Append($"{objectProperty.Name} {direction}, ");
    }

    var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');

    Console.WriteLine(orderQuery);

    if (string.IsNullOrWhiteSpace(orderQuery))
    {
      return newQuery;
    }

    newQuery = newQuery.OrderBy(orderQuery);

    return newQuery;
  }

  public async Task<bool> CreateUser(CreateUserDto dto)
  {
    IdentityRole? role =
      await EntityFrameworkQueryableExtensions.FirstOrDefaultAsync(_context.Roles,
        r => r.Name == dto.Role.GetDisplayName());

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

    throw new AggregateException(result.Errors.Select(e => new Exception(e.Description)));
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
      var users = await EntityFrameworkQueryableExtensions.ToListAsync(_userManager.Users);
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
    return await EntityFrameworkQueryableExtensions.ToListAsync(_userManager.Users);
  }

  public async Task<User?> GetMe(ClaimsPrincipal user)
  {
    string email = user.FindFirst(ClaimTypes.Email)!.Value;
    var getUser = await _userManager.FindByEmailAsync(email);
    return getUser;
  }

  public async Task<User?> FindById(string id)
  {
    return await _userManager.FindByIdAsync(id);
  }
}
