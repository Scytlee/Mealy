using Mealy.Domain.Common.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Mealy.Persistence.Common.Converters;

internal static class CommonConverterExtensions
{
  internal static void ConfigureCommonConventions(this ModelConfigurationBuilder builder)
  {
    builder.Properties<EnergyAmount>()
           .HaveConversion<EnergyAmountConverter>();
    
    builder.Properties<EntityVersion>()
           .HaveConversion<EntityVersionConverter>();
    
    builder.Properties<ProductAmount>()
           .HaveConversion<ProductAmountConverter>();
  }
}
