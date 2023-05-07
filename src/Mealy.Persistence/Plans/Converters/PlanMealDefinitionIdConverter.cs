using Mealy.Domain.Plans.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Plans.Converters;

internal sealed class PlanMealDefinitionIdConverter : ValueConverter<PlanMealDefinitionId, long>
{
  public PlanMealDefinitionIdConverter() : base(
    vo => vo.Value, 
    v => new PlanMealDefinitionId(v))
  {

  }
}
