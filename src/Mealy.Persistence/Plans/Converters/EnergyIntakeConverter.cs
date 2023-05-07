using Mealy.Domain.Plans.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Plans.Converters;

internal sealed class EnergyIntakeConverter : ValueConverter<EnergyIntake, int>
{
  public EnergyIntakeConverter() : base(
    vo => vo.Value, 
    v => EnergyIntake.Create(v).Value!)
  {
    
  }
}
