namespace pc28168U202422620.DisbursementOrder.Application.Commands;

public sealed record  CreateDisbursementOrderComand(
    Guid OrderTrackingCode,
    Guid AffiliateStoreId,
    DateOnly ScheduledFrom,
    DateOnly ScheduledTo,
    decimal TransferCapAmount,
    string TransferCapCurrencyCode,
    DisbursementStatus? Status,
    string User,
    string? Remarks);
