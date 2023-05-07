using Mealy.Domain.ShoppingLists.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Mealy.Persistence.ShoppingLists.Converters;

internal static class ShoppingListConverterExtensions
{
  internal static void ConfigureShoppingListConventions(this ModelConfigurationBuilder builder)
  {
    builder.Properties<ShoppingListId>()
           .HaveConversion<ShoppingListIdConverter>();
  }
}
