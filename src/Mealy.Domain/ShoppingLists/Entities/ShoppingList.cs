using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.ValueObjects;
using Mealy.Domain.Plans.Entities;
using Mealy.Domain.Plans.ValueObjects;
using Mealy.Domain.ShoppingLists.ValueObjects;

namespace Mealy.Domain.ShoppingLists.Entities;

public sealed class ShoppingList : Entity<ShoppingListId>, IAuditableEntity
{
  public PlanId PlanId { get; set; }
  public EntityVersion PlanVersion { get; set; }
  public DateOnly StartDate { get; set; }
  public DateOnly EndDate { get; set; }
  public DateTime CreatedOnUtc { get; set; }

  public ShoppingList(
    ShoppingListId id, 
    Plan plan, 
    DateOnly startDate, 
    DateOnly endDate) : base(id)
  {
    PlanId = plan.Id;
    PlanVersion = plan.Version;
    StartDate = startDate;
    EndDate = endDate;
  }
}
