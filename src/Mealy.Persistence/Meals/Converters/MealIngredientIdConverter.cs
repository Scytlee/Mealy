using Mealy.Domain.Meals.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Meals.Converters;

internal sealed class MealIngredientIdConverter : ValueConverter<MealIngredientId, long>
{
  public MealIngredientIdConverter() : base(
    vo => vo.Value, 
    v => new MealIngredientId(v))
  {
    
  }
}
