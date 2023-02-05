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
    public readonly AppDbContext Context;
    public readonly DbSet<T> DbSet;

    public BaseRepo(AppDbContext context)
    {
        Context = context;
        DbSet = Context.Set<T>();
    }

    public async Task<IEnumerable<T>> FindAll(string? relations = "")
    {
        IQueryable<T> query = DbSet;

        query = query.AsNoTracking();

        query = GetRelations(query, relations);

        return await query.ToListAsync();
    }

    public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate, string? relations = "")
    {
        IQueryable<T> query = DbSet;

        query = GetRelations(query, relations);

        query = query.Where(predicate);

        return await query.ToListAsync();
    }

    public IEnumerable<T> Paginate(out int totalRecords, PaginationFilter? paginationFilter = null,
      Expression<Func<T, bool>>? predicate = null, string? relations = "", string? orderByQueryString = "")
    {
        IQueryable<T> query = DbSet;
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
        IQueryable<T> query = DbSet;

        query = GetRelations(query, relations);

        return await query.FirstOrDefaultAsync(item => item.Id.Equals(id));
    }

    public async Task<int> CountAsync()
    {
        return await DbSet.CountAsync();
    }

    public int Count()
    {
        return DbSet.Count();
    }

    public async Task Add(T entity)
    {
        await DbSet.AddAsync(entity);
    }

    public void Update(T entity)
    {
        DbSet.Update(entity);
    }

    public void Delete(T entity)
    {
        DbSet.Remove(entity);
    }

    public void Delete(string id)
    {
        var entity = DbSet.Find(id);

        if (entity != null)
        {
            this.Delete(entity);
        }
    }

    public void DeleteRange(List<T> entities)
    {
        DbSet.RemoveRange(entities);
    }

    public void SoftDelete(T entity)
    {
        entity.IsDeleted = true;
        this.Update(entity);
    }

    public void UpdateRange(List<T> entities)
    {
        DbSet.UpdateRange(entities);
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
