using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Meals.ValueObjects;

public sealed class MealTypeId : ValueObject<long>, IEntityPrimaryKey
{
  private MealTypeId(long value) : base(value) {}
}
