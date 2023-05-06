using Mealy.Domain.Common.Primitives;
using Mealy.Domain.Common.Validation;
using Mealy.Domain.Products.Errors;

namespace Mealy.Domain.Products.ValueObjects;

public sealed class ProductCategoryName : ValueObject<string>
{
  public const int MaxLength = 50;

  private ProductCategoryName(string value) : base(value) {}

  public static Result<ProductCategoryName> Create(string name)
  {
    if (string.IsNullOrWhiteSpace(name))
    {
      return Result.Failure<ProductCategoryName>(DomainErrors.ProductCategoryName.Empty);
    }

    if (name.Length > MaxLength)
    {
      return Result.Failure<ProductCategoryName>(DomainErrors.ProductCategoryName.TooLong);
    }
    
    return new ProductCategoryName(name);
  }
}
