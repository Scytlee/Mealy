using Mealy.Domain.Products.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Mealy.Persistence.Products.Converters;

internal static class ProductConverterExtensions
{
  internal static void ConfigureProductConventions(this ModelConfigurationBuilder builder)
  {
    builder.Properties<ProductCategoryId>()
           .HaveConversion<ProductCategoryIdConverter>();
    
    builder.Properties<ProductCategoryName>()
           .HaveConversion<ProductCategoryNameConverter>();
    
    builder.Properties<ProductId>()
           .HaveConversion<ProductIdConverter>();
    
    builder.Properties<ProductName>()
           .HaveConversion<ProductNameConverter>();
  }
}
