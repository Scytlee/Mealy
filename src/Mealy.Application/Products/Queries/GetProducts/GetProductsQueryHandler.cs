using Mealy.Application.Abstractions.Messaging;
using Mealy.Application.Products.Models;
using Mealy.Application.Products.Repositories;
using Mealy.Domain.Common.Validation;
using System.Diagnostics;

namespace Mealy.Application.Products.Queries.GetProducts;

public sealed class GetProductsQueryHandler : IQueryHandler<GetProductsQuery, List<ProductShallowModel>>
{
  private readonly IProductRepository _productRepository;

  public GetProductsQueryHandler(IProductRepository productRepository)
  {
    _productRepository = productRepository;
  }

  public async Task<Result<List<ProductShallowModel>>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
  {
    var stopwatch = Stopwatch.StartNew();
    var result = Result.Success(await _productRepository.GetRangeAsync());
    stopwatch.Stop();
    Console.WriteLine(stopwatch.ElapsedMilliseconds);
    return result;
  }
}
