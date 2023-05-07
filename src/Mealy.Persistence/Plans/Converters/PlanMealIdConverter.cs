using Mealy.Domain.Plans.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Plans.Converters;

internal sealed class PlanMealIdConverter : ValueConverter<PlanMealId, long>
{
  public PlanMealIdConverter() : base(
    vo => vo.Value, 
    v => new PlanMealId(v))
  {

  }
}
