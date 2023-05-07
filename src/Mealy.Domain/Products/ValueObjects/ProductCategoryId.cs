using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Products.ValueObjects;

public sealed class ProductCategoryId : ValueObject<long>, IEntityPrimaryKey
{
  public ProductCategoryId(long value) : base(value) {}
}
