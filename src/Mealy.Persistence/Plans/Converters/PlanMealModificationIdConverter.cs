using Mealy.Domain.Plans.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Plans.Converters;

internal sealed class PlanMealModificationIdConverter : ValueConverter<PlanMealModificationId, long>
{
  public PlanMealModificationIdConverter() : base(
    vo => vo.Value, 
    v => new PlanMealModificationId(v))
  {

  }
}
