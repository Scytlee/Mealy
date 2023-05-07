using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Plans.ValueObjects;

public sealed class PlanMealModificationId : ValueObject<long>, IEntityPrimaryKey
{
  public PlanMealModificationId(long value) : base(value) {}
}
