namespace Mealy.Domain.Common.Primitives;

public abstract record ValueObject<T>(T Value) : ValueObject
  where T : notnull
{
  public static implicit operator T(ValueObject<T> valueObject) => valueObject.Value;
}
