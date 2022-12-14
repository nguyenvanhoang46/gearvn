using api.Models;
using api.Models.Morph;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Context;

public class AppDbContext : IdentityDbContext<User>
{
  public DbSet<User> User { get; set; }

  public DbSet<Product> Product { get; set; }

  public DbSet<Category> Category { get; set; }

  public DbSet<Order> Order { get; set; }

  public DbSet<OrderDetail> OrderDetail { get; set; }

  public DbSet<Image> Image { get; set; }

  public DbSet<Role> Role { get; set; }

  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
  {
  }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    base.OnModelCreating(builder);
  }
}
