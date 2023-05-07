using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.ShoppingLists.ValueObjects;

public sealed class ShoppingListId : ValueObject<long>, IEntityPrimaryKey
{
  public ShoppingListId(long value) : base(value) {}
}
