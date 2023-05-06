using Mealy.Domain.Common.Interfaces;
using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Products.ValueObjects;

public sealed class ProductCategoryId : ValueObject<long>, IEntityPrimaryKey
{
  private ProductCategoryId(long value) : base(value) {}
}
