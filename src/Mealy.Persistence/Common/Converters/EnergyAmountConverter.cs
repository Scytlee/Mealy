using Mealy.Domain.Common.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Common.Converters;

public class EnergyAmountConverter : ValueConverter<EnergyAmount, double>
{
  public EnergyAmountConverter() : base(
    vo => vo.Value,
    v => EnergyAmount.Create(v).Value!) 
  {
    
  }
}
