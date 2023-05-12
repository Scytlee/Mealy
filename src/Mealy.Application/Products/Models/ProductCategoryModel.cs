using Mealy.Domain.Products.ValueObjects;

namespace Mealy.Application.Products.Models;

public sealed record ProductCategoryModel(
  ProductCategoryId Id, 
  ProductCategoryName Name);
