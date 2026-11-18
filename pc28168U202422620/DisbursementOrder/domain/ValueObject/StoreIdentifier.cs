namespace pc28168U202422620.DisbursementOrder.domain.ValueObject;

public sealed record StoreIdentifier
{
    
    public  Guid Value { get; }
    
    
    public StoreIdentifier(Guid value)
    {
        if (value == Guid.Empty)
        {
            
            throw new ArgumentException("Value cannot be empty", nameof(value));
        }
        
        Value = value;
    }
    
}