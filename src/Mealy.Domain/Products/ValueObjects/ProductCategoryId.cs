using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Products.ValueObjects;

public sealed record ProductCategoryId(long Value) : ValueObject<long>(Value), IEntityPrimaryKey;
