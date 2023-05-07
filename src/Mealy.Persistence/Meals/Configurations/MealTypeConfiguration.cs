using Mealy.Domain.Meals.Entities;
using Mealy.Domain.Meals.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mealy.Persistence.Meals.Configurations;

internal sealed class MealTypeConfiguration : IEntityTypeConfiguration<MealType>
{
  public void Configure(EntityTypeBuilder<MealType> builder)
  {
    builder.HasKey(e => e.Id);
    
    builder.Property(e => e.Name)
           .HasMaxLength(MealTypeName.MaxLength);
  }
}
