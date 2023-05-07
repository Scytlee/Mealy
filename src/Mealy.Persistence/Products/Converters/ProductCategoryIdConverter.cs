using Mealy.Domain.Products.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Products.Converters;

public class ProductCategoryIdConverter : ValueConverter<ProductCategoryId, long>
{
  public ProductCategoryIdConverter() : base(
    vo => vo.Value,
    v => new ProductCategoryId(v))
  {
    
  }
}
