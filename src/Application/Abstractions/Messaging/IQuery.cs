using ConveApp.Domain.Abstractions;
using MediatR;

namespace ConveApp.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
