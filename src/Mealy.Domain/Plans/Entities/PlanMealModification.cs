using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.ValueObjects;
using Mealy.Domain.Meals.Entities;
using Mealy.Domain.Meals.ValueObjects;
using Mealy.Domain.Plans.ValueObjects;
using Mealy.Domain.Products.Entities;
using Mealy.Domain.Products.ValueObjects;

namespace Mealy.Domain.Plans.Entities;

public class PlanMealModification : Entity<PlanMealModificationId>
{
  public PlanMealId PlanMealId { get; set; }
  public ModificationType Type { get; set; }
  public MealIngredientId MealIngredientId { get; set; }
  public ProductId? NewIngredientId { get; set; }
  public ProductAmount? Amount { get; set; }

  public PlanMealModification(
    PlanMealModificationId id,
    PlanMeal planMeal,
    ModificationType type,
    MealIngredient mealIngredient,
    Product? newIngredient,
    ProductAmount? amount) : base(id)
  {
    PlanMealId = planMeal.Id;
    Type = type;
    MealIngredientId = mealIngredient.Id;
    NewIngredientId = newIngredient?.Id;
    Amount = amount;
  }
}
