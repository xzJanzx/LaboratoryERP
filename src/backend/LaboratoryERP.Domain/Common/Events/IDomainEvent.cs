using MediatR;

namespace LaboratoryERP.Domain.Common.Events;

/// <summary>
/// Represents a domain event.
/// </summary>
public interface IDomainEvent : INotification
{
}