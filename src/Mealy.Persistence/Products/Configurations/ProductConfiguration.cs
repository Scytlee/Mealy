using Mealy.Domain.Products.Entities;
using Mealy.Domain.Products.ValueObjects;
using Mealy.Persistence.Common.Converters;
using Mealy.Persistence.Products.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mealy.Persistence.Products.Configurations;

internal sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
  public void Configure(EntityTypeBuilder<Product> builder)
  {
    builder.HasKey(e => e.Id);
    
    builder.Property(e => e.Id)
           .HasConversion<ProductIdConverter>();

    builder.Property(e => e.Name)
           .HasConversion<ProductNameConverter>()
           .HasMaxLength(ProductName.MaxLength);
    
    builder.Property(e => e.CategoryId)
           .HasConversion<ProductCategoryIdConverter>();
    
    builder.Property(e => e.EnergyAmountInKcal)
           .HasConversion<EnergyAmountConverter>();
    
    builder.HasOne(e => e.Category)
           .WithMany()
           .HasForeignKey(e => e.CategoryId);
  }
}
