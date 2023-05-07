using Mealy.Domain.Meals.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Meals.Converters;

internal sealed class MealNameConverter : ValueConverter<MealName, string>
{
  public MealNameConverter() : base(
    vo => vo.Value, 
    v => MealName.Create(v).Value!)
  {
    
  }
}
