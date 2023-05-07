using Mealy.Domain.Meals.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Meals.Converters;

internal sealed class MealTypeIdConverter : ValueConverter<MealTypeId, long>
{
  public MealTypeIdConverter() : base(
    vo => vo.Value, 
    v => new MealTypeId(v))
  {
    
  }
}
