using Mealy.Application.Abstractions.Repositories;

namespace Mealy.Persistence;

internal sealed class UnitOfWork : IUnitOfWork
{
  private readonly MealyDbContext _dbContext;
  
  public UnitOfWork(MealyDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  public async Task SaveChangesAsync(CancellationToken cancellationToken = default) => await _dbContext.SaveChangesAsync(cancellationToken);
}
