using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.Validation;
using Mealy.Domain.Meals.Errors;

namespace Mealy.Domain.Meals.ValueObjects;

public sealed class MealTypeName : ValueObject<string>
{
  public const int MaxLength = 50;

  private MealTypeName(string value) : base(value) {}

  public static Result<MealTypeName> Create(string name)
  {
    if (string.IsNullOrWhiteSpace(name))
    {
      return Result.Failure<MealTypeName>(DomainErrors.MealTypeName.Empty);
    }

    if (name.Length > MaxLength)
    {
      return Result.Failure<MealTypeName>(DomainErrors.MealTypeName.TooLong);
    }
    
    return new MealTypeName(name);
  }
}
