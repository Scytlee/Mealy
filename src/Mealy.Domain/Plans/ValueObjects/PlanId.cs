using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Plans.ValueObjects;

public sealed class PlanId : ValueObject<long>, IEntityPrimaryKey
{
  public PlanId(long value) : base(value) {}
}
