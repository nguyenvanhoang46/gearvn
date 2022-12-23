using api.Context;
using api.Models.Morph;
using api.Repository.IRepo;

namespace api.Repository;

public class ImageRepo : BaseRepo<Image>, IImageRepo
{
  public ImageRepo(AppDbContext context) : base(context)
  {
  }
}
