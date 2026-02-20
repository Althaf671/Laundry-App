using src.Domain.Common;
using src.Domain.Exceptions;

namespace src.Domain.ValueObjects;

public sealed class Money : ValueObject
{
    // Property
    public decimal Value { get; }

    public string Currency { get; } = "IDR";

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

        // normalize currency - take rp -> IDR
        var normalizeCurrency = NormalizeCurrency(currency);
        if (normalizeCurrency.IsFailure)
            return Result<Money>.Failure(normalizeCurrency.Error);

        // normalize money - take 1000 -> IDR 1000,00
        var normalizeValue = NormalizeMoney(value, normalizeCurrency.Value!);
        if (normalizeValue.IsFailure)
            return Result<Money>.Failure(normalizeCurrency.Error);

        // round to nearest - take 1143 -> 1100
        var roundedMoney = RoundToNearest(value);
        if (roundedMoney.IsFailure)
            return Result<Money>.Failure(roundedMoney.Error);

        // validate invariant
        var validation = ValidateInvariant(normalizeValue.Value, normalizeCurrency.Value!);
        if (validation.IsFailure)
            return Result<Money>.Failure(validation.Error);

        return Result<Money>.Success(
            new Money(normalizeValue.Value, normalizeCurrency.Value!));
    }

    // Private constructor
    private Money(decimal normalizeValue, string normalizeCurrency)
    {
        if (string.IsNullOrWhiteSpace(normalizeCurrency))
            throw new InvalidValueObjectState("");

        Value = normalizeValue;
        Currency = normalizeCurrency;
    }

    // Validate Invariant
    private static Result ValidateInvariant(decimal value, string currency)
    {
        // Can't be empty

        // 
        return Result.Success;
    }

    // Normalize currency
    private static Result<string> NormalizeCurrency(string currency)
    {
        return Result<string>.Success();
    }

    // Normalize value
    private static Result<decimal> NormalizeMoney(decimal value, string normalizedCurrency)
    {
        return Result<string>.Success();
    }

    // Round to nearest
    private static Result<decimal> RoundToNearest(decimal value)
    {
        return Result<decimal>.Success();
    }
}

