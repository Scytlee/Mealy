using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Products.ValueObjects;

namespace Mealy.Domain.Products.Entities;

public sealed class ProductCategory : Entity<ProductCategoryId>
{
  public ProductCategoryName Name { get; private set; }
  public bool IncludeInShoppingLists { get; private set; }

  public ProductCategory(
    ProductCategoryId id, 
    ProductCategoryName name, 
    bool includeInShoppingLists) : base(id)
  {
    Name = name;
    IncludeInShoppingLists = includeInShoppingLists;
  }
}
