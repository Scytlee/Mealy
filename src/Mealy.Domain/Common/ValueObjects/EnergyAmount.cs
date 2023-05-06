using Mealy.Domain.Common.Errors;
using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.Validation;

namespace Mealy.Domain.Common.ValueObjects;

public sealed class EnergyAmount : ValueObject<double>
{
  private EnergyAmount(double value) : base(value) {}
  
  public static Result<EnergyAmount> Create(double value)
  {
    if (value < 0)
    {
      return Result.Failure<EnergyAmount>(DomainErrors.EnergyAmount.Negative);
    }
    if (value > 900)
    {
      return Result.Failure<EnergyAmount>(DomainErrors.EnergyAmount.TooHigh);
    }
    
    return new EnergyAmount(value);
  }
}
