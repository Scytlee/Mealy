using Mealy.Domain.Common.Primitives;

namespace Mealy.Domain.Products.ValueObjects;

public sealed record ProductId(long Value) : ValueObject<long>(Value), IEntityPrimaryKey;
