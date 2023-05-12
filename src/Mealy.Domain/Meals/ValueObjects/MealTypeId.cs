using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Meals.ValueObjects;

public sealed record MealTypeId(long Value) : ValueObject<long>(Value), IEntityPrimaryKey;
