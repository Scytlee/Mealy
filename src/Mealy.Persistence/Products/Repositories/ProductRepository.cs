using Mealy.Application.Products.Models;
using Mealy.Application.Products.Repositories;
using Mealy.Domain.Products.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mealy.Persistence.Products.Repositories;

public sealed class ProductRepository : IProductRepository
{
  private readonly MealyDbContext _dbContext;

  public ProductRepository(MealyDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  private static Func<MealyDbContext, IAsyncEnumerable<ProductShallowModel>> GetRangeAsyncQuery = EF.CompileAsyncQuery(
    (MealyDbContext dbContext) => 
      dbContext.Set<Product>()
               .Select(product => new ProductShallowModel(
                 product.Id,
                 product.Name,
                 product.Category.Name)));

  public async Task<List<ProductShallowModel>> GetRangeAsync()
  {
    var result = new List<ProductShallowModel>();
    
    await foreach (var product in GetRangeAsyncQuery(_dbContext))
    {
      result.Add(product);
    }

    return result;
  }
}
