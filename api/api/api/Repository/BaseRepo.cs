using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using api.Context;
using api.Filters;
using api.Models;
using api.Repository.IRepo;
using Microsoft.EntityFrameworkCore;

namespace api.Repository;

public class BaseRepo<T> : IRepo<T> where T : BaseEntity
{
  private readonly AppDbContext _context;
  private readonly DbSet<T> _dbSet;

  public BaseRepo(AppDbContext context)
  {
    _context = context;
    _dbSet = _context.Set<T>();
  }

  public async Task<IEnumerable<T>> FindAll(string? relations = "")
  {
    IQueryable<T> query = _dbSet;

    query = GetRelations(query, relations);

    return await query.ToListAsync();
  }

  public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate, string? relations = "")
  {
    IQueryable<T> query = _dbSet;

    query = GetRelations(query, relations);

    query = query.Where(predicate);

    return await query.ToListAsync();
  }

  public IEnumerable<T> Paginate(out int totalRecords, PaginationFilter? paginationFilter = null,
    Expression<Func<T, bool>>? predicate = null, string? relations = "", string? orderByQueryString = "")
  {
    IQueryable<T> query = _dbSet;
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

  public async Task<T?> FindById(string id, string? relations = "")
  {
    IQueryable<T> query = _dbSet;

    query = GetRelations(query, relations);

    return await query.FirstOrDefaultAsync(item => item.Id.Equals(id));
  }

  public async Task<int> CountAsync()
  {
    return await _dbSet.CountAsync();
  }

  public int Count()
  {
    return _dbSet.Count();
  }

  public async Task Add(T entity)
  {
    await _dbSet.AddAsync(entity);
  }

  public void Update(T entity)
  {
    _dbSet.Update(entity);
  }

  public void Delete(T entity)
  {
    _dbSet.Remove(entity);
  }

  public void Delete(string id)
  {
    var entity = _dbSet.Find(id);

    if (entity != null)
    {
      this.Delete(entity);
    }
  }

  public void DeleteRange(List<T> entities)
  {
    _dbSet.RemoveRange(entities);
  }

  public void SoftDelete(string id)
  {
    var entity = _dbSet.Find(id);

    if (entity != null)
    {
      entity.IsDeleted = true;
      this.Update(entity);
    }
  }

  public void UpdateRange(List<T> entities)
  {
    _dbSet.UpdateRange(entities);
  }

  private IQueryable<T> GetRelations(IQueryable<T> query, string? relations = "")
  {
    if (string.IsNullOrEmpty(relations)) return query;

    IQueryable<T> newQuery = query;

    foreach (var prop in relations.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
    {
      newQuery = newQuery.Include(prop);
    }

    return newQuery;
  }

  // Required Package System.Linq.Dynamic.Core
  private IQueryable<T> GetSorting(IQueryable<T> query, string? orderByQueryString = "")
  {
    if (string.IsNullOrEmpty(orderByQueryString)) return query;

    IQueryable<T> newQuery = query;

    var orderParams = orderByQueryString.Trim().Split(',');
    var propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
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
}
