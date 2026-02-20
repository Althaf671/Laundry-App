using System.Text.RegularExpressions;
using src.Domain.Common;
using src.Domain.Errors.ValueObjectErrors;
using src.Domain.Exceptions;

namespace src.Domain.ValueObjects;

public sealed partial class Email : ValueObject
{
    public string Value { get; } 

    public override IEnumerable<object> GetAtomicValue()
    {
        yield return Value;
    }

    // Create factory
    public static Result<Email> Create(string email)
    { 
        var normalize = email.ToLowerInvariant();

        var validation = ValidateInvariant(normalize);

        if (validation.IsFailure)
            return Result<Email>.Failure(validation.Error);

        return Result<Email>.Success(new Email(normalize));
    }

    private Email(string normalize)
    {
        if (string.IsNullOrWhiteSpace(normalize))
            throw new InvalidValueObjectState(
                $"EMAIL_IMPOSSIBLE_STATE: Email value can't be empty!");

        Value = normalize;
    }

    // Email Validate Invariant
    private static Result ValidateInvariant(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return Result.Failure(EmailErrors.ValueRequired());

        if (email.Length < 7)
            return Result.Failure(EmailErrors.InvalidFormat());

        if (email.Length > 50)
            return Result.Failure(EmailErrors.ExceedCharactersLimit());

        if (!EmailRegex().IsMatch(email))
            return Result.Failure(EmailErrors.InvalidFormat());

        var domain = email.Split('@').Last().ToLowerInvariant();
        if (!AllowedEmailDomain.Contains(domain))
            return Result.Failure(EmailErrors.UnknownDomain());

        return Result.Success;
    }

    [GeneratedRegex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
    private static partial Regex EmailRegex();

    private static readonly HashSet<string> AllowedEmailDomain = [
        "gmail.com",
        "outlook.com",
        "yahoo.com",
        "hotmail.com",
        "live.com",
        "icloud.com",
        "protonmail.com",
        "aol.com",
        "zoho.com"
    ];
}

