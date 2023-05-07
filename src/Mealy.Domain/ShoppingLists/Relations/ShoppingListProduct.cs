using Mealy.Domain.Common.ValueObjects;
using Mealy.Domain.Products.Entities;
using Mealy.Domain.Products.ValueObjects;
using Mealy.Domain.ShoppingLists.Entities;
using Mealy.Domain.ShoppingLists.ValueObjects;

namespace Mealy.Domain.ShoppingLists.Relations;

public sealed class ShoppingListProduct
{
  public ShoppingListId ShoppingListId { get; set; }
  public ProductId ProductId { get; set; }
  public ProductAmount Amount { get; set; }

  public ShoppingListProduct(
    ShoppingList shoppingList,
    Product product,
    ProductAmount amount)
  {
    ShoppingListId = shoppingList.Id;
    ProductId = product.Id;
    Amount = amount;
  }
}
