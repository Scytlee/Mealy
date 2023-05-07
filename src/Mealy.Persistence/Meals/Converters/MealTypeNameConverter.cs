using Mealy.Domain.Meals.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Meals.Converters;

internal sealed class MealTypeNameConverter : ValueConverter<MealTypeName, string>
{
  public MealTypeNameConverter() : base(
    vo => vo.Value, 
    v => MealTypeName.Create(v).Value!)
  {
    
  }
}
