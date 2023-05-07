using Mealy.Domain.Plans.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Plans.Converters;

internal sealed class PlanIdConverter : ValueConverter<PlanId, long>
{
  public PlanIdConverter() : base(
    vo => vo.Value, 
    v => new PlanId(v))
  {
    
  }
}
