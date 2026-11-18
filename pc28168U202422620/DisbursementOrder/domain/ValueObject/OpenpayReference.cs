namespace pc28168U202422620.DisbursementOrder.domain.ValueObject;

public record OpenpayReference
{
    public Guid Value { get; }

    public OpenpayReference(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new ArgumentException("OpenpayReference value cannot be empty.", nameof(value));
        }

        Value = value;
    }
}
