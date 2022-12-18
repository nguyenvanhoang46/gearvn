using api.Context;
using api.Models;
using api.Repository.IRepo;

namespace api.Repository;

public class CategoryRepo : BaseRepo<Category>, ICategoryRepo
{
  public CategoryRepo(AppDbContext context) : base(context)
  {
  }
}
