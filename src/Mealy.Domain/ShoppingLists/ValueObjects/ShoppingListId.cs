using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.ShoppingLists.ValueObjects;

public sealed record ShoppingListId(long Value) : ValueObject<long>(Value), IEntityPrimaryKey;
