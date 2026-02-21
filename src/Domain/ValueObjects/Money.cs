using src.Domain.Common;
using src.Domain.Errors.ValueObjectErrors;
using src.Domain.Exceptions;

namespace src.Domain.ValueObjects;

public sealed class Money : ValueObject
{
    // Property
    public decimal Value { get; }

    public string Currency { get; } 

    public override IEnumerable<object> GetAtomicValue()
    {
        yield return Value;
        yield return Currency;
    }

    // Factory
    public static Result<Money> Create(decimal value, string currency)
    {
        // pre-validate 
        if (string.IsNullOrWhiteSpace(currency))
            return Result<Money>.Failure(MoneyErrors.CurrencyRequired()); 

        // normalize currency 
        var normalizeCurrency = NormalizeCurrency(currency);
        if (normalizeCurrency.IsFailure)
            return Result<Money>.Failure(normalizeCurrency.Error);

        // validate invariant
        var validation = ValidateInvariant(value, normalizeCurrency.Value!);
        if (validation.IsFailure)
            return Result<Money>.Failure(validation.Error);

        return Result<Money>.Success(new Money(value, normalizeCurrency.Value!));
    }

    // Private constructor
    private Money(decimal normalizeValue, string normalizeCurrency)
    {
        if (string.IsNullOrWhiteSpace(normalizeCurrency))
            throw new InvalidValueObjectState(
                "IMPOSSIBLE_MONEY_STATE: Money currency can't be empty");

        Value = normalizeValue;
        Currency = normalizeCurrency;
    }

    // Validate Invariant
    private static Result ValidateInvariant(decimal value, string normalizeCurrency)
    {
        //  check if valid currency actual length is 3
        if (normalizeCurrency.Length != 3)
            return Result.Failure(MoneyErrors.InvalidValidCurrencyLength());

        // max value is 10 billion
        if (value > 10_000_000_000)
            return Result.Failure(MoneyErrors.ValueExceedPositiveLimit());

        // max negative value is 1 billion
        if (value < -1_000_000_000)
            return Result.Failure(MoneyErrors.ValueExceedNegativeLimit());

        return Result.Success;
    }

    // Normalize currency
    private static Result<string> NormalizeCurrency(string currency)
    {
        string validCurrencyCode = "IDR"; 
    
        // defensive empty string guard
        if (string.IsNullOrWhiteSpace(currency))
            return Result<string>.Failure(MoneyErrors.CurrencyRequired());

        // max length 5 for raw currency
        if (currency.Length > 5)
            return Result<string>.Failure(MoneyErrors.InvalidRawCurrencyLength());

        // remove first and last white space from raw currency
        var trimCurrency = currency.Trim(); 

        // convert trim currency to upper case
        var upperTrimCurrency = trimCurrency.ToUpperInvariant();

        // check if trim currency is equal to IDR or check is currency contain currency from dict
        if (trimCurrency.Equals(validCurrencyCode, StringComparison.InvariantCultureIgnoreCase))
        {
            return Result<string>.Success(trimCurrency.ToUpperInvariant());
        }
        else if (CurrencySymbolList.Contains(upperTrimCurrency))
        {
            return Result<string>.Success(validCurrencyCode);
        }
        else
        {
            return Result<string>.Failure(MoneyErrors.UnknownCurrencySymbol());
        }  
    }

    private static readonly HashSet<string> CurrencySymbolList = [
        "RP.",
        "RP"
    ];
}

