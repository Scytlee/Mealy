using Mealy.Domain.Products.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Products.Converters;

public class ProductNameConverter : ValueConverter<ProductName, string>
{
  public ProductNameConverter() : base(
    vo => vo.Value, 
    v => ProductName.Create(v).Value!)
  {

  }
}
