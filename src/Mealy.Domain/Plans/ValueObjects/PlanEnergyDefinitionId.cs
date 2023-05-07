using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Plans.ValueObjects;

public sealed class PlanEnergyDefinitionId : ValueObject<long>, IEntityPrimaryKey
{
  public PlanEnergyDefinitionId(long value) : base(value) {}
}
