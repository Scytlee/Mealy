using Mealy.Domain.Products.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Products.Converters;

internal sealed class ProductCategoryNameConverter : ValueConverter<ProductCategoryName, string>
{
  public ProductCategoryNameConverter() : base(
    vo => vo.Value,
    v => ProductCategoryName.Create(v).Value!)
  {
    
  }
}
