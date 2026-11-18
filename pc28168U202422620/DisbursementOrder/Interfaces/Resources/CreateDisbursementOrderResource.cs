namespace pc28168U202422620.DisbursementOrder.Interfaces.Resources;

using System.ComponentModel.DataAnnotations;

public sealed class CreateDisbursementOrderResource
{
    [Required]
    public string? OrderTrackingCode { get; init; }

    [Required]
    public string? AffiliateStoreId { get; init; }

    [Required]
    public string? ScheduledFrom { get; init; }

    [Required]
    public string? ScheduledTo { get; init; }

    [Required]
    public decimal? TransferCapAmount { get; init; }

    [Required]
    public string? TransferCapCurrencyCode { get; init; }

    public string? Status { get; init; }

    [Required]
    [StringLength(20)]
    public string? User { get; init; }

    [StringLength(85)]
    public string? Remarks { get; init; }
}