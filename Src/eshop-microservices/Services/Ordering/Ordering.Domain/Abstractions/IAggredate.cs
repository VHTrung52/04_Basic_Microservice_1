namespace Ordering.Domain.Abstractions;

public interface IAggredate<T> : IAggredate, IEntity<T>;

public interface IAggredate : IEntity
{
    IReadOnlyList<IDomainEvent> DomainEvents { get; }
    IDomainEvent[] ClearDomainEvents();
}