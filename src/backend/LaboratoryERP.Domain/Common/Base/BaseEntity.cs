using LaboratoryERP.Domain.Common.Events;

namespace LaboratoryERP.Domain.Common.Base;

/// <summary>
/// Base entity for all domain entities.
/// </summary>
public abstract class BaseEntity
{
    private readonly List<IDomainEvent> _domainEvents = [];

    protected BaseEntity()
    {
    }

    protected BaseEntity(Guid id)
    {
        Id = id;
    }

    /// <summary>
    /// Primary key.
    /// </summary>
    public Guid Id { get; protected set; }

    /// <summary>
    /// Domain events raised by the entity.
    /// </summary>
    public IReadOnlyCollection<IDomainEvent> DomainEvents =>
        _domainEvents.AsReadOnly();

    public void RaiseDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}