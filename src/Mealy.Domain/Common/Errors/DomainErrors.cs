using Mealy.Domain.Common.Validation;

namespace Mealy.Domain.Common.Errors;

public static class DomainErrors
{
  public static class ProductCategoryName
  {
    public static readonly Error Empty = new(
      "ProductCategoryName.Empty", 
      "Product category name cannot be empty.");
    public static readonly Error TooLong = new(
      "ProductCategoryName.TooLong",
      $"Product category name cannot be longer than {Products.ValueObjects.ProductCategoryName.MaxLength} characters.");
  }
  
  public static class EnergyAmount
  {
    public static readonly Error Negative = new(
      "EnergyAmount.Negative",
      "Energy amount cannot be negative.");
  }
  
  public static class ProductName
  {
    public static readonly Error Empty = new(
      "ProductName.Empty", 
      "Product name cannot be empty.");
    public static readonly Error TooLong = new(
      "ProductName.TooLong",
      $"Product name cannot be longer than {Products.ValueObjects.ProductName.MaxLength} characters.");
  }
}
