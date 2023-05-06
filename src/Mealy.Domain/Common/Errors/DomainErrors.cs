using Mealy.Domain.Common.Validation;

namespace Mealy.Domain.Common.Errors;

public static class DomainErrors
{
  public static class EnergyAmount
  {
    public static readonly Error Negative = new(
      "EnergyAmount.Negative",
      "Energy amount cannot be negative.");
    public static readonly Error TooHigh = new(
      "EnergyAmount.TooHigh",
      "Energy amount cannot be higher than 900 calories.");
  }
}
