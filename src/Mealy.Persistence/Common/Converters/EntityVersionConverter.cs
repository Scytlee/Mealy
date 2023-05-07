using Mealy.Domain.Common.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence.Common.Converters;

internal sealed class EntityVersionConverter : ValueConverter<EntityVersion, int>
{
  public EntityVersionConverter() : base(
    vo => vo.Value, 
    v => EntityVersion.Create(v).Value!)
  {
    
  }
}
