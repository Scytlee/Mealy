using Mealy.Domain.Common.Validation;

namespace Mealy.Domain.Products.Errors;

public static class DomainErrors
{
  public static class ProductName
  {
    public static readonly Error Empty = new(
      "ProductName.Empty", 
      "Product name cannot be empty.");
    public static readonly Error TooLong = new(
      "ProductName.TooLong",
      $"Product name cannot be longer than {ValueObjects.ProductName.MaxLength} characters.");
  }
  
  public static class ProductCategoryName
  {
    public static readonly Error Empty = new(
      "ProductCategoryName.Empty", 
      "Product category name cannot be empty.");
    public static readonly Error TooLong = new(
      "ProductCategoryName.TooLong",
      $"Product category name cannot be longer than {ValueObjects.ProductCategoryName.MaxLength} characters.");
  }
}