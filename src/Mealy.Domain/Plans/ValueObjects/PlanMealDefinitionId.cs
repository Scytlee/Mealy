using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Plans.ValueObjects;

public sealed class PlanMealDefinitionId : ValueObject<long>, IEntityPrimaryKey
{
  public PlanMealDefinitionId(long value) : base(value) {}
}
