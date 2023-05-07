using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.ValueObjects;
using Mealy.Domain.Plans.Enums;
using Mealy.Domain.Plans.ValueObjects;

namespace Mealy.Domain.Plans.Entities;

public sealed class PlanEnergyDefinition : Entity<PlanEnergyDefinitionId>
{
  public PlanId PlanId { get; set; }
  public EntityVersion PlanVersion { get; set; }
  public EnergyIntake EnergyIntake { get; set; }
  public Weekdays? Weekdays { get; set; }
  public DateOnly? StartDate { get; set; }
  public DateOnly? EndDate { get; set; }

  public PlanEnergyDefinition(
    PlanEnergyDefinitionId id, 
    Plan plan,
    EnergyIntake energyIntake,
    Weekdays? weekdays, 
    DateOnly? startDate, 
    DateOnly? endDate) : base(id)
  {
    PlanId = plan.Id;
    PlanVersion = plan.Version;
    EnergyIntake = energyIntake;
    Weekdays = weekdays;
    StartDate = startDate;
    EndDate = endDate;
  }
}
