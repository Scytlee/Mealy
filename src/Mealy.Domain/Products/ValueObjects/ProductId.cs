using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Products.ValueObjects;

public sealed class ProductId : ValueObject<long>, IEntityPrimaryKey
{
  public ProductId(long value) : base(value) {}
}
