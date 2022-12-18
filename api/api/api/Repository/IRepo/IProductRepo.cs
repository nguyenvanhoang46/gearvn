using api.Models;

namespace api.Repository.IRepo;

public interface IProductRepo : IRepo<Product>
{
  public List<Product> Search(IEnumerable<Product> products, string searchKey, List<string> field);
}
