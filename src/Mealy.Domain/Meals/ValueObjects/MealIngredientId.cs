using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Meals.ValueObjects;

public sealed record MealIngredientId(long Value) : ValueObject<long>(Value), IEntityPrimaryKey;
