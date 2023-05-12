using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Plans.ValueObjects;

public sealed record PlanMealDefinitionId(long Value) : ValueObject<long>(Value), IEntityPrimaryKey;
