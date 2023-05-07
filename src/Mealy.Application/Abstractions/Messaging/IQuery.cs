using Mealy.Domain.Common.Validation;
using MediatR;

namespace Mealy.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
  
}
