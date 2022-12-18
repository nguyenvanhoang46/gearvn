using api.Models;
using api.Repository;
using api.Repository.IRepo;
using api.Services.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace api.Context;

public class UnitOfWork : IUnitOfWork
{
  private readonly AppDbContext _context;
  private IUserRepo _userRepository;
  private IProductRepo _productRepository;
  private ICategoryRepo _categoryRepository;
  private readonly UserManager<User> _userManager;
  private readonly SignInManager<User> _signInManager;
  private readonly IJwtService _jwtService;
  private readonly IConfiguration _configuration;

  public UnitOfWork(
    AppDbContext context,
    UserManager<User> userManager,
    IProductRepo productRepository,
    IUserRepo userRepository,
    SignInManager<User> signInManager,
    IJwtService jwtService,
    IConfiguration configuration,
    ICategoryRepo categoryRepository
  )
  {
    _context = context;
    _userManager = userManager;
    _productRepository = productRepository;
    _userRepository = userRepository;
    _categoryRepository = categoryRepository;
    _signInManager = signInManager;
    _jwtService = jwtService;
    _configuration = configuration;
  }

  public IUserRepo UserRepository =>
    _userRepository = _userRepository ??
                      new UserRepo(_context, _userManager, _signInManager, _jwtService, _configuration);

  public IProductRepo ProductRepository =>
    _productRepository = _productRepository ??
                         new ProductRepo(_context);

  public ICategoryRepo CategoryRepository =>
    _categoryRepository = _categoryRepository ??
                          new CategoryRepo(_context);

  public void Save() => _context.SaveChanges();

  public void Rollback() => _context.Dispose();

  public async Task SaveAsync() => await _context.SaveChangesAsync();

  public async Task RollbackAsync() => await _context.DisposeAsync();

  public async Task SoftDeleteAsync<T>(T entity) where T : BaseEntity
  {
    entity.IsDeleted = true;
    await _context.SaveChangesAsync();
  }
}
