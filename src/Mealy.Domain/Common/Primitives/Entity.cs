namespace Mealy.Domain.Common.Primitives;

public abstract class Entity<TPrimaryKey> : IEquatable<Entity<TPrimaryKey>>
  where TPrimaryKey : ValueObject, IEntityPrimaryKey
{
  public TPrimaryKey Id { get; }
  
  protected Entity(TPrimaryKey id)
  {
    Id = id;
  }

  public static bool operator ==(Entity<TPrimaryKey>? first, Entity<TPrimaryKey>? second) => first is not null && second is not null && first.Equals(second);

  public static bool operator !=(Entity<TPrimaryKey>? first, Entity<TPrimaryKey>? second) => !(first == second);

  public bool Equals(Entity<TPrimaryKey>? other)
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

    if (obj is not Entity<TPrimaryKey> entity)
    {
      return false;
    }

    return Id == entity.Id;
  }

  public override int GetHashCode() => Id.GetHashCode() * 37;
}
