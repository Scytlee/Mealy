using Mealy.Domain.Plans.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Plans.Converters;

internal sealed class PlanEnergyDefinitionIdConverter : ValueConverter<PlanEnergyDefinitionId, long>
{
  public PlanEnergyDefinitionIdConverter() : base(
    vo => vo.Value, 
    v => new PlanEnergyDefinitionId(v))
  {

  }
}
