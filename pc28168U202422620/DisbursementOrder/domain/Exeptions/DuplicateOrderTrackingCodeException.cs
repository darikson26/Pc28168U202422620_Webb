namespace pc28168U202422620.DisbursementOrder.domain.Exeptions;

public sealed class DuplicateOrderTrackingCodeException : Exception
{
    public DuplicateOrderTrackingCodeException()
        : base("A disbursement order with this order tracking code already exists.")
    {
    }
}