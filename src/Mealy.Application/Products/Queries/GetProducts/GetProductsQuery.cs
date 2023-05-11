using Mealy.Application.Abstractions.Messaging;
using Mealy.Application.Products.Models;

namespace Mealy.Application.Products.Queries.GetProducts;

public sealed record GetProductsQuery : IQuery<List<ProductShallowModel>>;