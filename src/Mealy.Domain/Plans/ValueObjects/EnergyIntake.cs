using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.Validation;
using Mealy.Domain.Plans.Errors;

namespace Mealy.Domain.Plans.ValueObjects;

public sealed record EnergyIntake : ValueObject<int>
{
  private EnergyIntake(int value) : base(value) {}
  
  public static Result<EnergyIntake> Create(int value)
  {
    if (value < 0)
    {
      return Result.Failure<EnergyIntake>(DomainErrors.EnergyIntake.Negative);
    }
    
    return new EnergyIntake(value);
  }
}
