using Mealy.Domain.Meals.Entities;
using Mealy.Domain.Meals.ValueObjects;
using Mealy.Persistence.Common.Converters;
using Mealy.Persistence.Meals.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mealy.Persistence.Meals.Configurations;

internal sealed class MealConfiguration : IEntityTypeConfiguration<Meal>
{
  public void Configure(EntityTypeBuilder<Meal> builder)
  {
    builder.HasKey(e => new { e.Id, e.Version });
    
    builder.Property(e => e.Id)
           .HasConversion<MealIdConverter>();
    
    builder.Property(e => e.Version)
           .HasConversion<EntityVersionConverter>();
    
    builder.Property(e => e.Name)
           .HasConversion<MealNameConverter>()
           .HasMaxLength(MealName.MaxLength);
    
    builder.Property(e => e.Recipe)
           .HasConversion<RecipeConverter>()
           .HasMaxLength(Recipe.MaxLength);
    
    builder.Property(e => e.TypeId)
           .HasConversion<MealTypeIdConverter>();
    
    builder.Property(e => e.EnergyAmount)
           .HasConversion<EnergyAmountConverter>();
    
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
