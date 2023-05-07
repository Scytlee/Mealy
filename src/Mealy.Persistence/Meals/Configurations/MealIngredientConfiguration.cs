using Mealy.Domain.Meals.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mealy.Persistence.Meals.Configurations;

internal sealed class MealIngredientConfiguration : IEntityTypeConfiguration<MealIngredient>
{
  public void Configure(EntityTypeBuilder<MealIngredient> builder)
  {
    builder.HasKey(e => e.Id);
    
    builder.HasOne(e => e.Product)
           .WithMany()
           .HasForeignKey(e => e.ProductId);
  }
}
