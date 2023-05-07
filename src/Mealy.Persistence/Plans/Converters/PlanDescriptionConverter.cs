using Mealy.Domain.Plans.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Plans.Converters;

internal sealed class PlanDescriptionConverter : ValueConverter<PlanDescription, string>
{
  public PlanDescriptionConverter() : base(
    vo => vo.Value, 
    v => PlanDescription.Create(v).Value!)
  {

  }
}
