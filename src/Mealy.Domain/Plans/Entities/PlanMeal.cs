using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.ValueObjects;
using Mealy.Domain.Meals.Entities;
using Mealy.Domain.Meals.ValueObjects;
using Mealy.Domain.Plans.ValueObjects;

namespace Mealy.Domain.Plans.Entities;

public sealed class PlanMeal : Entity<PlanMealId>
{
  public PlanMealDefinition PlanMealDefinition { get; set; }
  public PlanMealDefinitionId PlanMealDefinitionId { get; set; }
  public DateOnly Date { get; set; }
  public Meal Meal { get; set; }
  public MealId MealId { get; set; }
  public EntityVersion MealVersion { get; set; }
  public EnergyAmount EnergyAmount { get; set; }

  public PlanMeal(
    PlanMealId id, 
    PlanMealDefinition planMealDefinition,
    DateOnly date, 
    Meal meal, 
    EnergyAmount energyAmount) : base(id)
  {
    PlanMealDefinition = planMealDefinition;
    PlanMealDefinitionId = planMealDefinition.Id;
    Date = date;
    Meal = meal;
    MealId = meal.Id;
    MealVersion = meal.Version;
    EnergyAmount = energyAmount;
  }
}
