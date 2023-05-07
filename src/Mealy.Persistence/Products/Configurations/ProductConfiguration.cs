using Mealy.Domain.Products.Entities;
using Mealy.Domain.Products.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mealy.Persistence.Products.Configurations;

internal sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
  public void Configure(EntityTypeBuilder<Product> builder)
  {
    builder.HasKey(e => e.Id);

    builder.Property(e => e.Name)
           .HasMaxLength(ProductName.MaxLength);
    
    builder.HasOne(e => e.Category)
           .WithMany()
           .HasForeignKey(e => e.CategoryId);
  }
}
