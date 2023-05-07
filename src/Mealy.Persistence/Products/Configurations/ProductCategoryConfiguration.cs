using Mealy.Domain.Products.Entities;
using Mealy.Domain.Products.ValueObjects;
using Mealy.Persistence.Products.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mealy.Persistence.Products.Configurations;

internal sealed class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
{
  public void Configure(EntityTypeBuilder<ProductCategory> builder)
  {
    builder.HasKey(e => e.Id);

    builder.Property(e => e.Id)
           .HasConversion<ProductCategoryIdConverter>();

    builder.Property(e => e.Name)
           .HasConversion<ProductCategoryNameConverter>()
           .HasMaxLength(ProductCategoryName.MaxLength);
    
    builder.HasIndex(e => e.Name)
           .IsUnique();
  }
}