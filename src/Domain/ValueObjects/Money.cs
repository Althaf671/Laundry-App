using src.Domain.Common;

namespace src.Domain.ValueObjects;

public class Money : ValueObject
{
    public decimal Amount { get; init; }
    
    public override IEnumerable<object> GetAtomicValue()
    {
        yield return Amount;
    }

    // Behaviour
}