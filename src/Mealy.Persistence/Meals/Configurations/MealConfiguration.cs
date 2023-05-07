using Mealy.Domain.Meals.Entities;
using Mealy.Domain.Meals.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mealy.Persistence.Meals.Configurations;

internal sealed class MealConfiguration : IEntityTypeConfiguration<Meal>
{
  public void Configure(EntityTypeBuilder<Meal> builder)
  {
    builder.HasKey(e => new { e.Id, e.Version });
    
    builder.Property(e => e.Name)
           .HasMaxLength(MealName.MaxLength);
    
    builder.Property(e => e.Recipe)
           .HasMaxLength(Recipe.MaxLength);
    
    builder.Property(e => e.CreatedOnUtc)
           .HasPrecision(0);
    
    builder.HasOne(e => e.Type)
           .WithMany()
           .HasForeignKey(e => e.TypeId);
    
    builder.HasMany(e => e.Ingredients)
           .WithOne()
           .HasForeignKey(e => new { e.MealId, e.MealVersion });
  }
}
