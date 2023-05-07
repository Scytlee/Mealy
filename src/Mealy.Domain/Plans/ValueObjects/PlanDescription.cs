using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.Validation;
using Mealy.Domain.Plans.Errors;

namespace Mealy.Domain.Plans.ValueObjects;

public sealed class PlanDescription : ValueObject<string>
{
  public const int MaxLength = 1000;

  public PlanDescription(string value) : base(value) {}
  
  public static Result<PlanDescription> Create(string description)
  {
    if (string.IsNullOrWhiteSpace(description))
    {
      return Result.Failure<PlanDescription>(DomainErrors.PlanDescription.Empty);
    }

    if (description.Length > MaxLength)
    {
      return Result.Failure<PlanDescription>(DomainErrors.PlanDescription.TooLong);
    }
    
    return new PlanDescription(description);
  }
}
