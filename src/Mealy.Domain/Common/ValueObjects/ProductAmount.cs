using Mealy.Domain.Common.Errors;
using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.Validation;

namespace Mealy.Domain.Common.ValueObjects;

public sealed class ProductAmount : ValueObject<double>
{
  private ProductAmount(double value) : base(value) {}
  
  public static Result<ProductAmount> Create(double value)
  {
    if (value <= 0)
    {
      return Result.Failure<ProductAmount>(DomainErrors.ProductAmount.NonPositive);
    }
    
    return new ProductAmount(value);
  }
}
