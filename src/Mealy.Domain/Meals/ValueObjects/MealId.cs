using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Meals.ValueObjects;

public sealed class MealId : ValueObject<long>, IEntityPrimaryKey
{
  private MealId(long value) : base(value) {}
}
