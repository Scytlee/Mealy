using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Meals.ValueObjects;

public sealed class MealIngredientId : ValueObject<long>, IEntityPrimaryKey
{ 
  public MealIngredientId(long value) : base(value) {}
}
