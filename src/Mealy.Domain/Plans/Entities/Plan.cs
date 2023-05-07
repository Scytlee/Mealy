using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.ValueObjects;
using Mealy.Domain.Plans.ValueObjects;

namespace Mealy.Domain.Plans.Entities;

public sealed class Plan : VersionedEntity<PlanId>, IAuditableEntity
{
  public PlanName Name { get; set; }
  public PlanDescription Description { get; set; }
  public DateOnly StartDate { get; set; }
  public DateOnly EndDate { get; set; }
  public DateTime CreatedOnUtc { get; set; }

  public Plan(
    PlanId id, 
    EntityVersion version, 
    bool isLatestVersion, 
    PlanName name, 
    PlanDescription description,
    DateOnly startDate,
    DateOnly endDate) : base(id, version, isLatestVersion)
  {
    Name = name;
    Description = description;
    StartDate = startDate;
    EndDate = endDate;
  }
}
