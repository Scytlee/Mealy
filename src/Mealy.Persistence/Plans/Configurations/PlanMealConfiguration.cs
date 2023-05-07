using Mealy.Domain.Plans.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mealy.Persistence.Plans.Configurations;

internal sealed class PlanMealConfiguration : IEntityTypeConfiguration<PlanMeal>
{
  public void Configure(EntityTypeBuilder<PlanMeal> builder)
  {
    builder.HasKey(e => e.Id);
    
    builder.HasMany(e => e.Modifications)
           .WithOne()
           .HasForeignKey(e => e.PlanMealId);
  }
}
