using api.Context;
using api.Models;
using api.Repository.IRepo;
using Microsoft.EntityFrameworkCore;

namespace api.Repository;

public class OrderRepo : BaseRepo<Order>, IOrderRepo
{
  public OrderRepo(AppDbContext context) : base(context)
  {
  }

  public Task<List<Order>> GetAllOrderByUserId(string id)
  {
    return Context.Order.Where(x => x.User.Id == id).ToListAsync();
  }
}
