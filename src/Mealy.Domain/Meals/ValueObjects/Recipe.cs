using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.Validation;
using Mealy.Domain.Meals.Errors;

namespace Mealy.Domain.Meals.ValueObjects;

public sealed class Recipe : ValueObject<string>
{
  public const int MaxLength = 4000;
  
  public Recipe(string value) : base(value) {}
  
  public static Result<Recipe> Create(string recipe)
  {
    if (string.IsNullOrWhiteSpace(recipe))
    {
      return Result.Failure<Recipe>(DomainErrors.Recipe.Empty);
    }

    if (recipe.Length > MaxLength)
    {
      return Result.Failure<Recipe>(DomainErrors.Recipe.TooLong);
    }
    
    return new Recipe(recipe);
  }
}
