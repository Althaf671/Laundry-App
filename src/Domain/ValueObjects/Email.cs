using System.Text.RegularExpressions;
using src.Domain.Common;
using src.Domain.Errors;
using src.Domain.Errors.ValueObjectErrors;

namespace src.Domain.ValueObjects;

public class Email : ValueObject
{
    public string Value { get; init; } = string.Empty;

    public override IEnumerable<object> GetAtomicValue()
    {
        yield return Value;
    }

    // Create factory
    public static Result<Email> Create(string email, string action = nameof(Create))
    { 
        var validation = Validator(email, action);

        if (validation.IsFailure)
            return Result<Email>.Failure(validation.Error);

        return Result<Email>.Success(new Email{ Value = email.ToLowerInvariant() });
    }

    // Update factory
    public static Result<Email> Update(string email)
    {
        return Create(email, nameof(Update));

    }

    // Deactivate
    // public static Result<bool> Deactivate()
    // {
        
    // }

    // Email validator
    private static Result Validator(string email, string action)
    {
        if (string.IsNullOrWhiteSpace(email))
            return Result
                .Failure(CommonError.RequiredField
                    (nameof(Email), $"{nameof(email)} in {nameof(Validator)} method"));

        if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            return Result.Failure(EmailErrors.InvalidFormat(action));
            

        if (email.Length < 7)
            return Result.Failure(EmailErrors.InvalidFormat(action));

        if (email.Length >= 100)
            return Result.Failure(EmailErrors.ExceedCharactersLimit(action));

        return Result.Success;
    }
}