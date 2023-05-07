using Mealy.Domain.Meals.Entities;
using Mealy.Persistence.Common.Converters;
using Mealy.Persistence.Meals.Converters;
using Mealy.Persistence.Products.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mealy.Persistence.Meals.Configurations;

internal sealed class MealIngredientConfiguration : IEntityTypeConfiguration<MealIngredient>
{
  public void Configure(EntityTypeBuilder<MealIngredient> builder)
  {
    builder.HasKey(e => e.Id);
    
    builder.Property(e => e.Id)
           .HasConversion<MealIngredientIdConverter>();
    
    builder.Property(e => e.MealId)
           .HasConversion<MealIdConverter>();
    
    builder.Property(e => e.MealVersion)
           .HasConversion<EntityVersionConverter>();
    
    builder.Property(e => e.ProductId)
           .HasConversion<ProductIdConverter>();
    
    builder.Property(e => e.Amount)
           .HasConversion<ProductAmountConverter>();
    
    builder.Property(e => e.EnergyAmount)
           .HasConversion<EnergyAmountConverter>();
    
    builder.HasOne(e => e.Product)
           .WithMany()
           .HasForeignKey(e => e.ProductId);
  }
}
