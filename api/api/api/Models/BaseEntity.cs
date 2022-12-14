using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using api.Models.Interface;

namespace api.Models;

public abstract class BaseEntity : IEntity
{
  [Key] [Required] public string Id { get; set; } = Guid.NewGuid().ToString();

  public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

  public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

  public bool IsDeleted { get; set; } = false;
}
