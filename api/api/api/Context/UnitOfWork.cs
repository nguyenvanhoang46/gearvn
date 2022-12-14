using api.Models;
using api.Repository;
using api.Repository.IRepo;
using api.Services;
using api.Services.IServices;
using Microsoft.AspNetCore.Identity;

namespace api.Context;

public class UnitOfWork : IUnitOfWork
{
  private readonly AppDbContext _context;
  private IUserRepo _userRepository;
  private readonly UserManager<User> _userManager;
  private readonly SignInManager<User> _signInManager;
  private readonly IJwtService _jwtService;
  private readonly IConfiguration _configuration;

  public UnitOfWork(
    AppDbContext context,
    UserManager<User> userManager,
    SignInManager<User> signInManager,
    IJwtService jwtService,
    IConfiguration configuration
  )
  {
    _context = context;
    _userManager = userManager;
    _signInManager = signInManager;
    _jwtService = jwtService;
    _configuration = configuration;
  }

  public IUserRepo UserRepository =>
    _userRepository = _userRepository ??
                      new UserRepo(_context, _userManager, _signInManager, _jwtService, _configuration);

  public void Save() => _context.SaveChanges();

  public void Rollback() => _context.Dispose();

  public async Task SaveAsync() => await _context.SaveChangesAsync();

  public async Task RollbackAsync() => await _context.DisposeAsync();
}
