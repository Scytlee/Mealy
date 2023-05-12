using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Plans.ValueObjects;

public sealed record PlanId(long Value) : ValueObject<long>(Value), IEntityPrimaryKey;
