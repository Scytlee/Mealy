﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mealy.Persistence;

public sealed class MealyDbContext : DbContext
{
  public MealyDbContext(DbContextOptions options) : base(options) {}

  protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);

  protected override void ConfigureConventions(ModelConfigurationBuilder builder)
  {
    builder.Properties<DateOnly>()
           .HaveConversion<DateOnlyConverter>()
           .HaveColumnType("date");
    
    builder.Properties<TimeOnly>()
           .HaveConversion<TimeOnlyConverter>()
           .HaveColumnType("time");
    
    base.ConfigureConventions(builder);
  }
}

// ReSharper disable once ClassNeverInstantiated.Global
internal sealed class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
{
  public DateOnlyConverter() : base(
    dateOnly => dateOnly.ToDateTime(TimeOnly.MinValue), 
    dateTime => DateOnly.FromDateTime(dateTime))
  {
    
  }
}

// ReSharper disable once ClassNeverInstantiated.Global
internal sealed class TimeOnlyConverter : ValueConverter<TimeOnly, TimeSpan>
{
  public TimeOnlyConverter() : base(
    timeOnly => timeOnly.ToTimeSpan(), 
    timeSpan => TimeOnly.FromTimeSpan(timeSpan))
  {
    
  }
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