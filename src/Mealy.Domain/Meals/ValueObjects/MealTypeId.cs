using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Meals.ValueObjects;

public sealed class MealTypeId : ValueObject<long>, IEntityPrimaryKey
{
  public MealTypeId(long value) : base(value) {}
}
