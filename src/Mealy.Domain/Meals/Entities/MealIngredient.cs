using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.ValueObjects;
using Mealy.Domain.Meals.ValueObjects;
using Mealy.Domain.Products.Entities;
using Mealy.Domain.Products.ValueObjects;

namespace Mealy.Domain.Meals.Entities;

public class MealIngredient : Entity<MealIngredientId>
{
  public MealId MealId { get; private set; }
  public EntityVersion MealVersion { get; private set; }
  public Product Product { get; private set; }
  public ProductId ProductId { get; private set; }
  public ProductAmount Amount { get; private set; }
  public EnergyAmount EnergyAmount { get; private set; }
  
  private MealIngredient() : base(default) {}

  public MealIngredient(
    MealIngredientId id, 
    MealId mealId, 
    EntityVersion mealVersion, 
    Product product, 
    ProductId productId, 
    ProductAmount amount, 
    EnergyAmount energyAmount) : base(id)
  {
    MealId = mealId;
    MealVersion = mealVersion;
    Product = product;
    ProductId = productId;
    Amount = amount;
    EnergyAmount = energyAmount;
  }
}
