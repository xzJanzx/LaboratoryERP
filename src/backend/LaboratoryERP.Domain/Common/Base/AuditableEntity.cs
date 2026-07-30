namespace LaboratoryERP.Domain.Common.Base;

/// <summary>
/// Represents an auditable entity.
/// </summary>
public abstract class AuditableEntity : BaseEntity
{
    public DateTime CreatedOnUtc { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastModifiedOnUtc { get; set; }

    public Guid? LastModifiedBy { get; set; }
}