using api.Context;
using api.Models;
using api.Repository.IRepo;

namespace api.Repository;

public class ProductRepo : BaseRepo<Product>, IProductRepo
{
  public ProductRepo(AppDbContext context) : base(context)
  {
  }

  public List<Product> Search(IEnumerable<Product> products, string searchKey, List<string> field)
  {
    return products.Where(x => field.Any(f =>
        x.GetType().GetProperty(f).GetValue(x, null).ToString()
          .Contains(searchKey, StringComparison.OrdinalIgnoreCase)))
      .ToList();
  }
}
