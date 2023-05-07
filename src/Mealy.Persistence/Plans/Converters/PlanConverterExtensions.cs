using Mealy.Domain.Plans.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Mealy.Persistence.Plans.Converters;

internal static class PlanConverterExtensions
{
  internal static void ConfigurePlanConventions(this ModelConfigurationBuilder builder)
  {
    builder.Properties<EnergyIntake>()
           .HaveConversion<EnergyIntakeConverter>();
    
    builder.Properties<PlanDescription>()
           .HaveConversion<PlanDescriptionConverter>();
    
    builder.Properties<PlanEnergyDefinitionId>()
           .HaveConversion<PlanEnergyDefinitionIdConverter>();
    
    builder.Properties<PlanId>()
           .HaveConversion<PlanIdConverter>();
    
    builder.Properties<PlanMealDefinitionId>()
           .HaveConversion<PlanMealDefinitionIdConverter>();
    
    builder.Properties<PlanMealId>()
           .HaveConversion<PlanMealIdConverter>();
    
    builder.Properties<PlanMealModificationId>()
           .HaveConversion<PlanMealModificationIdConverter>();
    
    builder.Properties<PlanName>()
           .HaveConversion<PlanNameConverter>();
  }
}
