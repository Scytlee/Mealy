using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.Validation;
using Mealy.Domain.Meals.Errors;

namespace Mealy.Domain.Meals.ValueObjects;

public sealed record MealName : ValueObject<string>
{
  public const int MaxLength = 50;

  private MealName(string value) : base(value) {}

  public static Result<MealName> Create(string name)
  {
    if (string.IsNullOrWhiteSpace(name))
    {
      return Result.Failure<MealName>(DomainErrors.MealName.Empty);
    }

    if (name.Length > MaxLength)
    {
      return Result.Failure<MealName>(DomainErrors.MealName.TooLong);
    }
    
    return new MealName(name);
  }
}
