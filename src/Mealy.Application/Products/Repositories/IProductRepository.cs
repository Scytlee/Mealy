using Mealy.Application.Products.Models;
using Mealy.Domain.Products.ValueObjects;

namespace Mealy.Application.Products.Repositories;

public interface IProductRepository
{ 
  Task<List<ProductShallowModel>> GetRangeAsync();

  Task<ProductFullModel?> GetByIdAsync(ProductId id);
}
