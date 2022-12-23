using System.Data.Entity;
using api.Models;
using api.Repository.IRepo;
using Microsoft.AspNetCore.Identity;

namespace api.Repository;

public class RoleRepo : IRoleRepo
{
  private readonly RoleManager<Role> _roleManager;

  public RoleRepo(
    RoleManager<Role> roleManager
  )
  {
    _roleManager = roleManager;
  }

  public Task<List<Role>> GetRoles()
  {
    return _roleManager.Roles.ToListAsync();
  }

  public Task<Role> GetRoleByName(string name)
  {
    return _roleManager.Roles.FirstOrDefaultAsync(r => r.Name == name);
  }

  public Task<Role> GetRole(string id)
  {
    return _roleManager.Roles.FirstOrDefaultAsync(r => r.Id == id);
  }

  public Task<Role> AddRole(Role role)
  {
    return _roleManager.CreateAsync(role).ContinueWith(t => role);
  }

  public Task<Role> UpdateRole(Role role)
  {
    return _roleManager.UpdateAsync(role).ContinueWith(t => role);
  }

  public Task<Role> DeleteRole(string id)
  {
    return _roleManager.DeleteAsync(new Role { Id = id }).ContinueWith(t => new Role { Id = id });
  }
}
