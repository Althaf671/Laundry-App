using src.Domain.Common;
using src.Domain.ValueObjects;

namespace src.Domain.Errors.ValueObjectErrors;
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
    
    public static Error InvalidRawCurrencyLength()
    {
        return new Error(
            "Money.InvalidCurrencyLength", 
            "Raw currency characters length can't exceed 5",
            _domain
        );    
    }

    public static Error UnknownCurrencySymbol()
    {
        return new Error(
            "Money.UnknownCurrencySymbol", "Currency symbol is not registered",
            _domain
        );
    }

    public static Error InvalidValidCurrencyLength()
    {
        return new Error(
            "Money.InvalidValidCurrencyLength", 
            "Valid currency characters length must be 3 because it's only IDR",
            _domain
        );          
    }

    public static Error ValueExceedPositiveLimit()
    {
        return new Error(
            "Money.ValueExceedPositiveLimit",
            "Value can't exceed positive 10.000.000.000 (10 billion)",
            _domain
        );
    }

    public static Error ValueExceedNegativeLimit()
    {
        return new Error(
            "Money.ValueExceedNegativeLimit",
            "Value can't exceed negative 1.000.000.000 (-1 billion)",
            _domain
        );
    }
}