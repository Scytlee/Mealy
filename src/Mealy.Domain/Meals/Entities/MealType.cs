using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Meals.ValueObjects;

namespace Mealy.Domain.Meals.Entities;

public sealed class MealType : Entity<MealTypeId>
{
  public MealTypeName Name { get; private set; }
  public TimeOnly DefaultTime { get; private set; }
  
  public MealType(
    MealTypeId id, 
    MealTypeName name,
    TimeOnly defaultTime) : base(id)
  {
    Name = name;
    DefaultTime = defaultTime;
  }
}
