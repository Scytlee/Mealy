using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.ValueObjects;
using Mealy.Domain.Meals.Entities;
using Mealy.Domain.Meals.ValueObjects;
using Mealy.Domain.Plans.ValueObjects;

namespace Mealy.Domain.Plans.Entities;

public sealed class PlanMeal : Entity<PlanMealId>
{
  private readonly List<PlanMealModification> _modifications = new();

  public PlanId PlanId { get; set; }
  public EntityVersion PlanVersion { get; set; }
  public DateOnly Date { get; set; }
  public Meal Meal { get; set; }
  public MealId MealId { get; set; }
  public EntityVersion MealVersion { get; set; }
  public EnergyAmount EnergyAmount { get; set; }
  public IReadOnlyList<PlanMealModification> Modifications => _modifications;
  
  private PlanMeal() : base(default) {}

  public PlanMeal(
    PlanMealId id, 
    Plan plan,
    DateOnly date, 
    Meal meal, 
    EnergyAmount energyAmount) : base(id)
  {
    PlanId = plan.Id;
    PlanVersion = plan.Version;
    Date = date;
    Meal = meal;
    MealId = meal.Id;
    MealVersion = meal.Version;
    EnergyAmount = energyAmount;
  }
}
