using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Plans.ValueObjects;

public sealed record PlanMealModificationId(long Value) : ValueObject<long>(Value), IEntityPrimaryKey;
