using System.Linq.Expressions;
using api.Filters;
using api.Models;

namespace api.Repository.IRepo;

public interface IRepo<TEntity> where TEntity : BaseEntity
{
  Task<IEnumerable<TEntity>> FindAll(string? relations = "");

  Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate,
    string? relations = "");

  IEnumerable<TEntity> Paginate(out int totalRecords, PaginationFilter? paginationFilter = null,
    Expression<Func<TEntity, bool>>? predicate = null, string? relations = "", string? orderByQueryString = "");

  Task<TEntity?> FindById(string id, string? relations = "");
  public Task<int> CountAsync();
  public int Count();
  Task Add(TEntity entity);
  void Update(TEntity entity);
  void UpdateRange(List<TEntity> entities);
  void Delete(TEntity entity);
  void Delete(string id);
  void DeleteRange(List<TEntity> entities);
  void SoftDelete(TEntity entity);
}
