namespace Mealy.Domain.Primitives;

public abstract class Entity : IEquatable<Entity>
{
  public long Id { get; private init; }
  
  protected Entity(long id)
  {
    Id = id;
  }

  public static bool operator ==(Entity? first, Entity? second) => first is not null && second is not null && first.Equals(second);

  public static bool operator !=(Entity? first, Entity? second) => !(first == second);

  public bool Equals(Entity? other)
  {
    if (other is null)
    {
      return false;
    }

    if (other.GetType() != GetType())
    {
      return false;
    }

    return Id == other.Id;
  }

  public override bool Equals(object? obj)
  {
    if (obj is null)
    {
      return false;
    }

    if (obj.GetType() != GetType())
    {
      return false;
    }

    if (obj is not Entity entity)
    {
      return false;
    }

    return Id == entity.Id;
  }

  public override int GetHashCode() => Id.GetHashCode() * 37;
}
