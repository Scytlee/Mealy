using Mealy.Domain.Common.Validation;

namespace Mealy.Domain.Common.Errors;

public static class DomainErrors
{
  public static class EnergyAmount
  {
    public static readonly Error Negative = new(
      "EnergyAmount.Negative",
      "Energy amount cannot be negative.");
  }
}
