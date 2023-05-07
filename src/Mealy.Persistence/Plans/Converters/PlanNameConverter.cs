using Mealy.Domain.Plans.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Plans.Converters;

internal sealed class PlanNameConverter : ValueConverter<PlanName, string>
{
  public PlanNameConverter() : base(
    vo => vo.Value, 
    v => PlanName.Create(v).Value!)
  {

  }
}
