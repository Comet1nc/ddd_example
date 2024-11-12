using UserManagement.Domain.Common;

namespace UserManagement.Core.Common;

public abstract class AggregateRoot : Entity
{
    protected AggregateRoot(Guid id) : base(id)
    {
    }

    protected AggregateRoot() { }

    protected readonly List<IDomainEvent> _domainEvents = new();

    public List<IDomainEvent> PopDomainEvents()
    {
        var copy = _domainEvents.ToList();
        _domainEvents.Clear();

        return copy;
    }
}