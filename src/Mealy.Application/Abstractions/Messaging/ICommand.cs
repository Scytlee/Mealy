using Mealy.Domain.Common.Validation;
using MediatR;

namespace Mealy.Application.Abstractions.Messaging;

public interface ICommand : IRequest<Result>
{
  
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
  
}
