using Mealy.Domain.Products.Entities;
using Mealy.Domain.Products.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mealy.Persistence.Products.Configurations;

internal sealed class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
{
  public void Configure(EntityTypeBuilder<ProductCategory> builder)
  {
    builder.HasKey(e => e.Id);

    builder.Property(e => e.Name)
           .HasMaxLength(ProductCategoryName.MaxLength);
    
    builder.HasIndex(e => e.Name)
           .IsUnique();
  }
}