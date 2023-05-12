using Mealy.Application.Abstractions.Messaging;
using Mealy.Application.Products.Models;
using Mealy.Application.Products.Repositories;
using Mealy.Domain.Common.Validation;
using System.Diagnostics;

namespace Mealy.Application.Products.Queries.GetProductById;

public sealed class GetProductByIdQueryHandler : IQueryHandler<GetProductByIdQuery, ProductFullModel?>
{
  private readonly IProductRepository _productRepository;

  public GetProductByIdQueryHandler(IProductRepository productRepository)
  {
    _productRepository = productRepository;
  }

  public async Task<Result<ProductFullModel?>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
  {
    var stopwatch = Stopwatch.StartNew();
    var product = await _productRepository.GetByIdAsync(request.Id);
    var result = product is not null
      ? Result.Success<ProductFullModel?>(product)
      : Result.Failure<ProductFullModel?>(new Error("Product.NotFound", $"Product with ID {request.Id.Value} was not found"));
    stopwatch.Stop();
    Console.WriteLine(stopwatch.ElapsedMilliseconds);
    return result;
  }
}
