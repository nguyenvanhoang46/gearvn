using api.Models;
using api.Models.Morph;
using Faker;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Context;

public class AppDbContext : IdentityDbContext<User>
{
  public DbSet<Product> Product { get; set; }

  public DbSet<Category> Category { get; set; }

  public DbSet<Order> Order { get; set; }

  public DbSet<OrderDetail> OrderDetail { get; set; }

  public DbSet<Image> Image { get; set; }

  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
  {
  }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    base.OnModelCreating(builder);
    SeedUser(builder);
    SeedRoles(builder);
    SeedUserRoles(builder);
    SeedCategory(builder);
    SeedProduct(builder);
  }

  private void SeedUser(ModelBuilder modelBuilder)
  {
    User admin = new User()
    {
      Id = "2dfb43f4-24d5-44a7-af3c-78196e881f23",
      UserName = "Admin",
      FirstName = "Admin",
      LastName = "Admin",
      NormalizedUserName = "ADMIN",
      NormalizedEmail = "ADMIN@GMAIL.COM",
      Email = "admin@gmail.com",
      PasswordHash = "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==" // password
    };

    User user = new User()
    {
      Id = "75fa9827-0f5f-41db-a825-64d68d242d7e",
      UserName = "User",
      FirstName = "User",
      LastName = "User",
      NormalizedUserName = "USER",
      NormalizedEmail = "USER@GMAIL.COM",
      Email = "user@gmail.com",
      PasswordHash = "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ=="
    };

    User guest = new User()
    {
      Id = "df31566d-5ccb-45dc-b1be-864d72133ca4",
      UserName = "Guest",
      FirstName = "Guest",
      LastName = "Guest",
      NormalizedUserName = "GUEST",
      NormalizedEmail = "GUEST@GMAIL.COM",
      Email = "guest@gmail.com",
      PasswordHash = "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ=="
    };

    modelBuilder.Entity<User>().HasData(admin);
    modelBuilder.Entity<User>().HasData(user);
    modelBuilder.Entity<User>().HasData(guest);
  }

  private void SeedRoles(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Role>().HasData(new Role()
    {
      Id = "cc3b4c20-7ab3-4daa-b777-0018ee8c615c",
      Name = UserRole.Admin.ToString(),
      NormalizedName = UserRole.Admin.ToString().ToUpper()
    });
    modelBuilder.Entity<Role>().HasData(new Role()
    {
      Id = "dddd1a59-3b57-45f6-96b5-91b3e269e87c",
      Name = UserRole.User.ToString(),
      NormalizedName = UserRole.User.ToString().ToUpper()
    });
    modelBuilder.Entity<Role>().HasData(new Role()
    {
      Id = "b600478d-f98b-4a27-aa95-14563920d28f",
      Name = UserRole.Guest.ToString(),
      NormalizedName = UserRole.Guest.ToString().ToUpper()
    });
  }

  private void SeedUserRoles(ModelBuilder modelBuilder)
  {
    // Admin Role
    modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>()
    {
      RoleId = "cc3b4c20-7ab3-4daa-b777-0018ee8c615c",
      UserId = "2dfb43f4-24d5-44a7-af3c-78196e881f23",
    });
    // User Role
    modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>()
    {
      RoleId = "dddd1a59-3b57-45f6-96b5-91b3e269e87c",
      UserId = "75fa9827-0f5f-41db-a825-64d68d242d7e",
    });
    // Guest Role
    modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>()
    {
      RoleId = "b600478d-f98b-4a27-aa95-14563920d28f",
      UserId = "df31566d-5ccb-45dc-b1be-864d72133ca4",
    });
  }

  private void SeedCategory(ModelBuilder modelBuilder)
  {
    for (int i = 10 - 1; i >= 0; i--)
    {
      string UUID = Guid.NewGuid().ToString();
      modelBuilder.Entity<Category>().HasData(
        new Category
        {
          Id = UUID,
          Name = Name.FullName()
        });
    }
  }

  private void SeedProduct(ModelBuilder modelBuilder)
  {
    for (int i = 10 - 1; i >= 0; i--)
    {
      string UUID = Guid.NewGuid().ToString();
      modelBuilder.Entity<Product>().HasData(
        new Product
        {
          Id = UUID,
          Name = Name.FullName(),
          Price = RandomNumber.Next(100000, 1000000),
          Content = Lorem.Paragraph(),
          Description = Lorem.Sentence()
        }
      );
    }
  }
}
