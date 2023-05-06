using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.Validation;
using Mealy.Domain.Products.Errors;

namespace Mealy.Domain.Products.ValueObjects;

public class ProductName : ValueObject<string>
{
  public const int MaxLength = 50;

  private ProductName(string value) : base(value) {}

  public static Result<ProductName> Create(string name)
  {
    if (string.IsNullOrWhiteSpace(name))
    {
      return Result.Failure<ProductName>(DomainErrors.ProductName.Empty);
    }

    if (name.Length > MaxLength)
    {
      return Result.Failure<ProductName>(DomainErrors.ProductName.TooLong);
    }
    
    return new ProductName(name);
  }
}
