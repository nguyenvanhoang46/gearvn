using api.Repository.IRepo;

namespace api.Context;

public interface IUnitOfWork
{
  IUserRepo UserRepository { get; }

  void Save();
  void Rollback();
  Task SaveAsync();
  Task RollbackAsync();
}
