using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Mealy.Persistence;

public sealed class MealyDbContext : DbContext
{
  public MealyDbContext(DbContextOptions options) : base(options) {}

  protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
}

internal sealed class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MealyDbContext>
{
  public MealyDbContext CreateDbContext(string[] args)
  {
    var optionsBuilder = new DbContextOptionsBuilder<MealyDbContext>();
    optionsBuilder.UseSqlServer();
    return new MealyDbContext(optionsBuilder.Options);
  }
}