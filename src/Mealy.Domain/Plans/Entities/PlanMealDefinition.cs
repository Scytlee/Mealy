using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.ValueObjects;
using Mealy.Domain.Meals.Entities;
using Mealy.Domain.Meals.ValueObjects;
using Mealy.Domain.Plans.Enums;
using Mealy.Domain.Plans.ValueObjects;

namespace Mealy.Domain.Plans.Entities;

public sealed class PlanMealDefinition : Entity<PlanMealDefinitionId>
{
  public PlanId PlanId { get; set; }
  public EntityVersion PlanVersion { get; set; }
  public MealTypeId TypeId { get; set; }
  public MealType Type { get; set; }
  public TimeOnly Time { get; set; }
  public Weekdays? Weekdays { get; set; }
  public DateOnly? StartDate { get; set; }
  public DateOnly? EndDate { get; set; }
  
  private PlanMealDefinition() : base(default) {}

  public PlanMealDefinition(
    PlanMealDefinitionId id, 
    Plan plan,
    MealType type,
    TimeOnly time,
    Weekdays? weekdays,
    DateOnly? startDate,
    DateOnly? endDate) : base(id)
  {
    PlanId = plan.Id;
    PlanVersion = plan.Version;
    TypeId = type.Id;
    Type = type;
    Time = time;
    Weekdays = weekdays;
    StartDate = startDate;
    EndDate = endDate;
  }
}
