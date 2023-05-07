using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.ValueObjects;
using Mealy.Domain.Meals.ValueObjects;

namespace Mealy.Domain.Meals.Entities;

public sealed class Meal : VersionedEntity<MealId>, IAuditableEntity
{
  private readonly List<MealIngredient> _ingredients = new();
  
  public MealName Name { get; set; }
  public Recipe? Recipe { get; set; }
  public MealType Type { get; set; }
  public MealTypeId TypeId { get; set; }
  public EnergyAmount EnergyAmount { get; set; }
  public DateTime CreatedOnUtc { get; set; }
  public IReadOnlyCollection<MealIngredient> Ingredients => _ingredients;

  public Meal(
    MealId id, 
    EntityVersion version, 
    bool isLatestVersion, 
    MealName name, 
    Recipe? recipe, 
    MealType type, 
    MealTypeId typeId, 
    EnergyAmount energyAmount) : base(id, version, isLatestVersion)
  {
    Name = name;
    Recipe = recipe;
    Type = type;
    TypeId = typeId;
    EnergyAmount = energyAmount;
  }

}
