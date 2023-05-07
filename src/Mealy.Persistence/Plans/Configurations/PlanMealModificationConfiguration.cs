using Mealy.Domain.Plans.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mealy.Persistence.Plans.Configurations;

internal sealed class PlanMealModificationConfiguration : IEntityTypeConfiguration<PlanMealModification>
{
  public void Configure(EntityTypeBuilder<PlanMealModification> builder)
  {
    builder.HasKey(e => e.Id);
  }
}
