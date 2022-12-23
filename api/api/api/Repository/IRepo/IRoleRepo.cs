using api.Models;

namespace api.Repository.IRepo;

public interface IRoleRepo
{
  public Task<List<Role>> GetRoles();
  public Task<Role> GetRoleByName(string name);
  public Task<Role> GetRole(string id);
  public Task<Role> AddRole(Role role);
  public Task<Role> UpdateRole(Role role);
  public Task<Role> DeleteRole(string id);
}
