using Mealy.Domain.Products.Entities;
using Mealy.Domain.ShoppingLists.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mealy.Persistence.ShoppingLists.Configurations;

internal sealed class ShoppingListProductConfiguration : IEntityTypeConfiguration<ShoppingListProduct>
{
  public void Configure(EntityTypeBuilder<ShoppingListProduct> builder)
  {
    builder.HasKey(e => new { e.ShoppingListId, e.ProductId });
    
    builder.HasOne<Product>()
           .WithMany()
           .HasForeignKey(e => e.ProductId);
  }
}
