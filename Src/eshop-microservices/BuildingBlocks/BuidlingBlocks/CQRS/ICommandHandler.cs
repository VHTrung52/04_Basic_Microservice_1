using MediatR;

namespace BuildingBlocks.CQRS;

public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
    where TCommand : IRequest<TResponse>
    where TResponse : notnull;

public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand>
    where TCommand : ICommand, IRequest;

// public interface ICommandHandler<in TCommand> : ICommandHandler<TCommand, Unit>
// where TCommand : ICommand<Unit>;