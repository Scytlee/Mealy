using Mealy.Domain.Meals.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Mealy.Persistence.Meals.Converters;

internal static class MealConverterExtensions
{
  internal static void ConfigureMealConventions(this ModelConfigurationBuilder builder)
  {
    builder.Properties<MealId>()
           .HaveConversion<MealIdConverter>();
    
    builder.Properties<MealIngredientId>()
           .HaveConversion<MealIngredientIdConverter>();
    
    builder.Properties<MealName>()
           .HaveConversion<MealNameConverter>();
    
    builder.Properties<MealTypeId>()
           .HaveConversion<MealTypeIdConverter>();
    
    builder.Properties<MealTypeName>()
           .HaveConversion<MealTypeNameConverter>();
    
    builder.Properties<Recipe>()
           .HaveConversion<RecipeConverter>();
  }
}
