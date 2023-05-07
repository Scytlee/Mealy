using Mealy.Domain.ShoppingLists.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mealy.Persistence.ShoppingLists.Configurations;

internal sealed class ShoppingListConfiguration : IEntityTypeConfiguration<ShoppingList>
{
  public void Configure(EntityTypeBuilder<ShoppingList> builder)
  {
    builder.HasKey(e => e.Id);
    
    builder.Property(e => e.CreatedOnUtc)
           .HasPrecision(0);
    
    builder.HasMany(e => e.Products)
           .WithOne()
           .HasForeignKey(e => e.ShoppingListId);
  }
}
