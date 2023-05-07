﻿namespace Mealy.Application.Abstractions.Repositories;

public interface IUnitOfWork
{
  Task SaveChangesAsync(CancellationToken cancellationToken = default);
}
