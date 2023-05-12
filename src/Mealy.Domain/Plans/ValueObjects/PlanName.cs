using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.Validation;
using Mealy.Domain.Plans.Errors;

namespace Mealy.Domain.Plans.ValueObjects;

public sealed record PlanName : ValueObject<string>
{
  public const int MaxLength = 100;
  
  private PlanName(string value) : base(value) {}
  
  public static Result<PlanName> Create(string name)
  {
    if (string.IsNullOrWhiteSpace(name))
    {
      return Result.Failure<PlanName>(DomainErrors.PlanName.Empty);
    }

    if (name.Length > MaxLength)
    {
      return Result.Failure<PlanName>(DomainErrors.PlanName.TooLong);
    }
    
    return new PlanName(name);
  }
}
