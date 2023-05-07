using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Plans.ValueObjects;

public sealed class PlanMealId : ValueObject<long>, IEntityPrimaryKey
{
  public PlanMealId(long value) : base(value) {}
}
