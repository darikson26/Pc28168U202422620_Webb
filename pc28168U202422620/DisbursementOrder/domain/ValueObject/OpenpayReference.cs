namespace pc28168U202422620.DisbursementOrder.domain.ValueObject;

public sealed record OpenpayReference
{
    private OpenpayReference()
    {
    }

    public OpenpayReference(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; private set; }
}
