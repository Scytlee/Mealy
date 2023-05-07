using Mealy.Domain.Plans.Entities;
using Mealy.Domain.Plans.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mealy.Persistence.Plans.Configurations;

internal sealed class PlanConfiguration : IEntityTypeConfiguration<Plan>
{
  public void Configure(EntityTypeBuilder<Plan> builder)
  {
    builder.HasKey(e => new { e.Id, e.Version });
    
    builder.Property(e => e.Name)
           .HasMaxLength(PlanName.MaxLength);
    
    builder.Property(e => e.Description)
           .HasMaxLength(PlanDescription.MaxLength);
    
    builder.Property(e => e.CreatedOnUtc)
           .HasPrecision(0);
    
    builder.HasMany(e => e.MealDefinitions)
           .WithOne()
           .HasForeignKey(e => new { e.PlanId, e.PlanVersion });
    
    builder.HasMany(e => e.EnergyDefinitions)
           .WithOne()
           .HasForeignKey(e => new { e.PlanId, e.PlanVersion });
    
    builder.HasMany(e => e.Meals)
           .WithOne()
           .HasForeignKey(e => new { e.PlanId, e.PlanVersion });
  }
}
