namespace pc28168U202422620.DisbursementOrder.domain.ValueObject;

public sealed record StoreIdentifier
{
    private StoreIdentifier()
    {
    }

    public StoreIdentifier(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; private set; }
}