using Mealy.Domain.Common.ValueObjects;
using Mealy.Domain.Products.ValueObjects;

namespace Mealy.Application.Products.Models;

public sealed record ProductFullModel(
  ProductId Id, 
  ProductName Name, 
  ProductCategoryModel Category, 
  EnergyAmount EnergyAmountInKcal,
  bool IncludeInShoppingLists);
