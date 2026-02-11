using src.Domain.Common;

namespace src.Domain.Errors.ValueObjectErrors;
public static class MoneyErros
{
    public static readonly Error InvalidCurrency = new(
        "Money.InvalidCurrency", "This currency is weather invalid or typo"
    );

    public static readonly Error InvalidAmount = new(
        "Money.InvalidAmount", "Money amount is not valid"
    );
}