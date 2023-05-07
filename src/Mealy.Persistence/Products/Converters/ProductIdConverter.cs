using Mealy.Domain.Products.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Products.Converters;

public class ProductIdConverter : ValueConverter<ProductId, long>
{
  public ProductIdConverter() : base(
    vo => vo.Value, 
    v => new ProductId(v))
  {
    
  }
}
