using src.Domain.Common;

namespace src.Domain.ValueObjects;
public static class MoneyErrors
{
    private static readonly string _domain = nameof(Money);

    public static Error CurrencyRequired()
    {
        return new Error(
            "Money.CurrencyRequired", "Currency is required",
            _domain
        );
    }
    
}