namespace LaboratoryERP.Domain.Common.Results;

/// <summary>
/// Represents a business or validation error.
/// </summary>
public sealed record Error(
    string Code,
    string Description)
{
    public static readonly Error None = new(
        string.Empty,
        string.Empty);
}