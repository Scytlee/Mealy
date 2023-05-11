using Mealy.Application.Products.Models;

namespace Mealy.Application.Products.Repositories;

public interface IProductRepository
{ 
  Task<List<ProductShallowModel>> GetRangeAsync();
}
