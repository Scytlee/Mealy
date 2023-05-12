using Mealy.Domain.Common.Errors;
using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.Validation;

namespace Mealy.Domain.Common.ValueObjects;

public sealed record EntityVersion : ValueObject<int>
{
  private EntityVersion(int value) : base(value) {}
  
  public static Result<EntityVersion> Create(int version)
  {
    if (version <= 0)
    {
      return Result.Failure<EntityVersion>(DomainErrors.EntityVersion.NonPositive);
    }
    
    return new EntityVersion(version);
  }
}
