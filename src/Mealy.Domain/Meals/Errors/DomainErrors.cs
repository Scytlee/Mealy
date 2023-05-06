using Mealy.Domain.Common.Validation;

namespace Mealy.Domain.Meals.Errors;

public static class DomainErrors
{
  public static class MealTypeName
  {
    public static readonly Error Empty = new(
      "MealTypeName.Empty",
      "Meal type name cannot be empty.");
    public static readonly Error TooLong = new(
      "MealTypeName.TooLong",
      $"Meal type name cannot be longer than {ValueObjects.MealTypeName.MaxLength} characters.");
  }
  
  public static class Recipe
  {
    public static readonly Error Empty = new(
      "Recipe.Empty",
      "Recipe cannot be empty.");
    public static readonly Error TooLong = new(
      "Recipe.TooLong",
      $"Recipe cannot be longer than {ValueObjects.Recipe.MaxLength} characters.");
  }
  
  public static class MealName
  {
    public static readonly Error Empty = new(
      "MealName.Empty",
      "Meal name cannot be empty.");
    public static readonly Error TooLong = new(
      "MealName.TooLong",
      $"Meal name cannot be longer than {ValueObjects.MealName.MaxLength} characters.");
  }
}
