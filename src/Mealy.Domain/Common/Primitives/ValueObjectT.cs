namespace Mealy.Domain.Common.Primitives;

public abstract class ValueObject<T> : ValueObject
  where T : notnull
{
  public T Value { get; }
  
  protected ValueObject(T value)
  {
    Value = value;
  }

  public static implicit operator T(ValueObject<T> valueObject) => valueObject.Value;

  public override IEnumerable<object> GetAtomicValues()
  {
    yield return Value;
  }
}
