using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Meals.ValueObjects;

public sealed class MealId : ValueObject<long>, IEntityPrimaryKey
{
  public MealId(long value) : base(value) {}
}
