using Mealy.Domain.Common.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Mealy.Persistence.Common.Converters;

internal static class CommonConverterExtensions
{
  internal static void ConfigureCommonConventions(this ModelConfigurationBuilder builder)
  {
    builder.Properties<EnergyAmount>()
           .HaveConversion<EnergyAmountConverter>()
           .HaveColumnType("decimal(9,4)");
    
    builder.Properties<EntityVersion>()
           .HaveConversion<EntityVersionConverter>();
    
    builder.Properties<ProductAmount>()
           .HaveConversion<ProductAmountConverter>()
           .HaveColumnType("decimal(9,4)");
  }
}
