using api.Context;
using api.Models;
using api.Repository.IRepo;

namespace api.Repository;

public class OrderDetailRepo : BaseRepo<OrderDetail>, IOrderDetailRepo
{
  public OrderDetailRepo(AppDbContext context) : base(context)
  {
  }
}
