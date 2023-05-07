using Mealy.Domain.Common.Validation;
using MediatR;

namespace Mealy.Application.Abstractions.Messaging;

public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result>
  where TCommand : ICommand
{
  
}

public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, Result<TResponse>>
   where TCommand : ICommand<TResponse>
{
  
}
