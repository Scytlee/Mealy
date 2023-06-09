﻿using Mealy.Domain.Common.ValueObjects;
using Mealy.Domain.Products.ValueObjects;

namespace Mealy.Application.Products.Models;

public sealed record ProductShallowModel(
  ProductId Id, 
  ProductName Name, 
  ProductCategoryName Category, 
  EnergyAmount EnergyAmountInKcal,
  bool IncludeInShoppingLists);
