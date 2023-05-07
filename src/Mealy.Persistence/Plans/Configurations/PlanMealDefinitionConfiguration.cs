using Mealy.Domain.Plans.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mealy.Persistence.Plans.Configurations;

internal sealed class PlanMealDefinitionConfiguration : IEntityTypeConfiguration<PlanMealDefinition>
{
  public void Configure(EntityTypeBuilder<PlanMealDefinition> builder)
  {
    builder.HasKey(e => e.Id);
  }
}
