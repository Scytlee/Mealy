using Mealy.Domain.Plans.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mealy.Persistence.Plans.Configurations;

internal sealed class PlanEnergyDefinitionConfiguration : IEntityTypeConfiguration<PlanEnergyDefinition>
{
  public void Configure(EntityTypeBuilder<PlanEnergyDefinition> builder)
  {
    builder.HasKey(e => e.Id);
  }
}
