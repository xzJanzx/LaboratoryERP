namespace LaboratoryERP.Domain.Common.Interfaces;

/// <summary>
/// Represents an entity that supports soft deletion.
/// </summary>
public interface ISoftDelete
{
    bool IsDeleted { get; set; }

    DateTime? DeletedOnUtc { get; set; }
}