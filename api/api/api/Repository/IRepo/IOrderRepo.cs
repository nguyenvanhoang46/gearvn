using api.Models;

namespace api.Repository.IRepo;

public interface IOrderRepo : IRepo<Order>
{
  Task<List<Order>> GetAllOrderByUserId(string id);
}
