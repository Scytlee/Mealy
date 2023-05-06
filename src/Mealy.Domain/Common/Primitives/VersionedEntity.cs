using Mealy.Domain.Common.ValueObjects;

namespace Mealy.Domain.Common.Primitives;

public abstract class VersionedEntity<TPrimaryKey> : Entity<TPrimaryKey>, IEquatable<VersionedEntity<TPrimaryKey>>
  where TPrimaryKey : ValueObject, IEntityPrimaryKey
{
  public EntityVersion Version { get; }
  public bool IsLatestVersion { get; private set; }
  
  protected VersionedEntity(TPrimaryKey id, EntityVersion version, bool isLatestVersion) : base(id)
  {
    Version = version;
    IsLatestVersion = isLatestVersion;
  }
  
  public bool Equals(VersionedEntity<TPrimaryKey>? other)
  {
    if (other is null)
    {
      return false;
    }

    if (other.GetType() != GetType())
    {
      return false;
    }

    return Id == other.Id && Version == other.Version;
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

    if (obj is not VersionedEntity<TPrimaryKey> entity)
    {
      return false;
    }

    return Id == entity.Id && Version == entity.Version;
  }

  public override int GetHashCode() => HashCode.Combine(Id, Version) * 37;
}
