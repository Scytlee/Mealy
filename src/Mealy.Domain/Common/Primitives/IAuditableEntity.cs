namespace Mealy.Domain.Common.Primitives;

public interface IAuditableEntity
{
  public DateTime CreatedOnUtc { get; set; }
}
