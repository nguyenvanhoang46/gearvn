using api.Models;
using api.Repository.IRepo;

namespace api.Context;

public interface IUnitOfWork
{
  IUserRepo UserRepository { get; }

  IProductRepo ProductRepository { get; }

  ICategoryRepo CategoryRepository { get; }

  IRoleRepo RoleRepository { get; }

  IImageRepo ImageRepository { get; }

  void Save();
  void Rollback();
  Task SaveAsync();
  Task RollbackAsync();

  Task SoftDeleteAsync<T>(T entity) where T : BaseEntity;
}
