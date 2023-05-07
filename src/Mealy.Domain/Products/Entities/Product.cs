using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.ValueObjects;
using Mealy.Domain.Products.ValueObjects;

namespace Mealy.Domain.Products.Entities;

public sealed class Product : Entity<ProductId>
{
  public ProductName Name { get; private set; }
  public ProductCategoryId CategoryId { get; private set; }
  public ProductCategory Category { get; private set; }
  public EnergyAmount EnergyAmountInKcal { get; private set; }
  public bool IncludeInShoppingLists { get; private set; }

  private Product() : base(null)
  {
    // External mapping
  }
  
  public Product(
    ProductId id, 
    ProductName name,
    ProductCategory category,
    EnergyAmount energyAmountInKcal,
    bool includeInShoppingLists) : base(id)
  {
    Name = name;
    CategoryId = category.Id;
    Category = category;
    EnergyAmountInKcal = energyAmountInKcal;
    IncludeInShoppingLists = includeInShoppingLists;
  }
}