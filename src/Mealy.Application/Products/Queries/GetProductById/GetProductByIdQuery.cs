using Mealy.Application.Abstractions.Messaging;
using Mealy.Application.Products.Models;
using Mealy.Domain.Products.ValueObjects;

namespace Mealy.Application.Products.Queries.GetProductById;

public sealed record GetProductByIdQuery(
  ProductId Id)
  : IQuery<ProductFullModel?>;
