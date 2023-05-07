using Mealy.Domain.ShoppingLists.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.ShoppingLists.Converters;

internal sealed class ShoppingListIdConverter : ValueConverter<ShoppingListId, long>
{
  public ShoppingListIdConverter() : base(
    vo => vo.Value, 
    v => new ShoppingListId(v))
  {

  }
}
