using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using api.Models.Morph;

namespace api.Models;

public class Product : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public long Price { get; set; } = 0;

    public int Quantity { get; set; } = 1;

    public long SalePrice { get; set; } = 0;

    public string Description { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    [ForeignKey("CategoryId")] public Category? Category { get; set; }

    public string? CategoryId { get; set; }

    public ICollection<Image>? Images { get; set; } = new List<Image>();
}
