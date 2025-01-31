using MediatR;

namespace Ordering.Domain.Abstractions;

public record IDomainEvent : INotification
{
    Guid EventId => Guid.NewGuid();
    public DateTime CreatedAt => DateTime.Now; //OccurredOn
    public string EventType => GetType().AssemblyQualifiedName;
}