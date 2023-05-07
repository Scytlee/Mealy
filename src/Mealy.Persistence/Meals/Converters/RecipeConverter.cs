using Mealy.Domain.Meals.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Meals.Converters;

internal sealed class RecipeConverter : ValueConverter<Recipe, string>
{
  public RecipeConverter() : base(
    vo => vo.Value, 
    v => Recipe.Create(v).Value!)
  {

  }
}
