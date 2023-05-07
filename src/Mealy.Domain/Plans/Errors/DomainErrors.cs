using Mealy.Domain.Common.Validation;

namespace Mealy.Domain.Plans.Errors;

public static class DomainErrors
{
  public static class PlanName
  {
    public static readonly Error Empty = new(
      "PlanName.Empty",
      "Plan name cannot be empty.");
    public static readonly Error TooLong = new(
      "PlanName.TooLong",
      $"Plan name cannot be longer than {ValueObjects.PlanName.MaxLength} characters.");
  }
  
  public static class PlanDescription
  {
    public static readonly Error Empty = new(
      "PlanDescription.Empty",
      "Plan description cannot be empty.");
    public static readonly Error TooLong = new(
      "PlanDescription.TooLong",
      $"Plan description cannot be longer than {ValueObjects.PlanDescription.MaxLength} characters.");
  }

  public static class EnergyIntake
  {
    public static readonly Error Negative = new(
      "EnergyIntake.Negative",
      "Energy intake cannot be negative.");
  }
}
