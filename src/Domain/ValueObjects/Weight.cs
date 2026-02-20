using src.Domain.Common;
using src.Domain.Errors.ValueObjectErrors;
using src.Domain.Exceptions;

namespace src.Domain.ValueObjects;

public sealed class Weight : ValueObject
{
    private static readonly string _allowedUnit = "KG";

    public decimal Value { get; }

    public string Unit { get; } = _allowedUnit;

    public override IEnumerable<object> GetAtomicValue()
    {
        yield return Value;
        yield return Unit;
    }

    // Create factory
    public static Result<Weight> Create(decimal value, string unit)
    {
        var upperCaseUnit = unit.ToUpperInvariant();

        var validation = ValidateInvariant(value, upperCaseUnit);

        if (validation.IsFailure)
            return Result<Weight>.Failure(validation.Error);

        return Result<Weight>.Success(new Weight(value, upperCaseUnit));
    }

    // Private constructor
    private Weight(decimal value, string unit)
    {
        if (string.IsNullOrWhiteSpace(unit) || value < 0)
            throw new InvalidValueObjectState($"WEIGHT_IMPOSSIBLE_STATE: Weight value and unit can't be empty!");

        Value = value;
        Unit = unit;
    }

    // Validator
    private static Result ValidateInvariant(decimal value, string unit)
    {
        // Unit can't be empty
        if (string.IsNullOrWhiteSpace(unit))
            return Result.Failure(WeightErrors.UnitRequired());

        // Unit max char is 7
        if (unit.Length > 7)
            return Result.Failure(WeightErrors.UnitMaxCharacters());

        // Unit must be KG
        if (unit != _allowedUnit)
            return Result.Failure(WeightErrors.NotAllowedUnit());

        // Value must not negative or exceed 100
        if (value < 0 || value > 100)
            return Result.Failure(WeightErrors.InvalidValue());

        return Result.Success;
    }
}