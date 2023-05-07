using Mealy.Domain.Common.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Common.Converters;

internal sealed class ProductAmountConverter : ValueConverter<ProductAmount, double>
{
  public ProductAmountConverter() : base(
    vo => vo.Value, 
    v => ProductAmount.Create(v).Value!)
  {
    
  }
}
