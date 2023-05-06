using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Products.ValueObjects;

public sealed class ProductId : ValueObject<long>, IEntityPrimaryKey
{
  private ProductId(long value) : base(value) {}
}
