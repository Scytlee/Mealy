namespace Mealy.Domain.Primitives;

public abstract class ValueObject : IEquatable<ValueObject>
{
  public abstract IEnumerable<object> GetAtomicValues();

  private bool ValuesAreEqual(ValueObject other) => GetAtomicValues().SequenceEqual(other.GetAtomicValues());

  public bool Equals(ValueObject? other) => other is not null && ValuesAreEqual(other);

  public override bool Equals(object? obj) => obj is ValueObject other && ValuesAreEqual(other);
  
  public static bool operator ==(ValueObject? first, ValueObject? second) => first is not null && second is not null && first.Equals(second);

  public static bool operator !=(ValueObject? first, ValueObject? second) => !(first == second);

  public override int GetHashCode() => GetAtomicValues().Aggregate(default(int), HashCode.Combine);
}
