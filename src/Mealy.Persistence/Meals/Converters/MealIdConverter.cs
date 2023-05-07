using Mealy.Domain.Meals.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Meals.Converters;

internal sealed class MealIdConverter : ValueConverter<MealId, long>
{
  public MealIdConverter() : base(
    vo => vo.Value, 
    v => new MealId(v))
  {
    
  }
}
