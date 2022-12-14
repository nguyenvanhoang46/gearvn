using System.ComponentModel;

namespace api.Models.Interface;

public interface IEntity
{
  string Id { get; set; }

  public DateTime CreatedAt { get; set; }

  public DateTime UpdatedAt { get; set; }

  public bool IsDeleted { get; set; }
}
