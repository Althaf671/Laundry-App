using System.Text.RegularExpressions;
using src.Domain.Common;
using src.Domain.Errors.ValueObjectErrors;
using src.Domain.Exceptions;

namespace src.Domain.ValueObjects;

public sealed partial class PhoneNumber : ValueObject 
{
    // Property
    public string Value { get; }

    public override IEnumerable<object> GetAtomicValue()
    {
        yield return Value;
    }

    // Factory
    public static Result<PhoneNumber> Create(string phoneNumber)
    {
        // pre-validation
        if (string.IsNullOrWhiteSpace(phoneNumber))
            return Result<PhoneNumber>.Failure(PhoneNumberErrors.ValueRequired());

        // normalize
        var normalize = Normalize(phoneNumber);
        if (normalize.IsFailure)
            return Result<PhoneNumber>.Failure(normalize.Error); 

        // validation
        var validation = ValidateInvariant(normalize.Value!);
        if (validation.IsFailure)
            return Result<PhoneNumber>.Failure(validation.Error);

        return Result<PhoneNumber>.Success(new PhoneNumber(normalize.Value!));
    }

    // Private Constructor
    private PhoneNumber(string formattedPhone)
    {
        if (string.IsNullOrWhiteSpace(formattedPhone))
            throw new InvalidValueObjectState(
                $"PHONENUMBER_IMPOSSIBLE_STATE: Phone number value can't be empty!");

        Value = formattedPhone;
    }

    // Validator
    private static Result ValidateInvariant(string phoneNumber)
    {
        // Maximum or minimum length is 10 or 25
        if (phoneNumber.Length < 10 || phoneNumber.Length > 25)
            return Result.Failure(PhoneNumberErrors.InvalidLength());
            
        // Do not allow non numeric characters
        if (!AllowNumeric().IsMatch(phoneNumber))
            return Result.Failure(PhoneNumberErrors.InvalidFormat());

        return Result.Success;
    }

    // Normalize raw phone number
    private static Result<string> Normalize(string phoneNumber)
    {
        // Remove white spaces
        var trimPhone = phoneNumber.Trim().Replace(" ", "");
        if (string.IsNullOrWhiteSpace(trimPhone))
            return Result<string>.Failure(PhoneNumberErrors.InvalidFormat());

        // Remove dashes
        var cleanPhone = trimPhone.Replace("-", "");
        if (cleanPhone.Contains('-'))
        {
            return Result<string>.Failure(PhoneNumberErrors.InvalidFormat());
        }

        // Normalize
        if (cleanPhone.StartsWith("08"))
        {
            return Result<string>.Success("+62" + cleanPhone[1..]);
        }
        else if (cleanPhone.StartsWith("62"))
        {
            var hasNumberEight = DoesContainsNumberEight(cleanPhone);
            if (hasNumberEight.IsFailure)
                return Result<string>.Failure(hasNumberEight.Error);
            
            var finalCleanPhone = "62" + hasNumberEight.Value;

            return Result<string>.Success("+" + finalCleanPhone);
        }
        else if (cleanPhone.StartsWith("+62"))
        {
            var hasNumberEight = DoesContainsNumberEight(cleanPhone);
            if (hasNumberEight.IsFailure)
                return Result<string>.Failure(hasNumberEight.Error);
            
            var finalCleanPhone = "+62" + hasNumberEight.Value;

            return Result<string>.Success(finalCleanPhone);
        }
        else
        {
            return Result<string>.Failure(PhoneNumberErrors.InvalidFormat());
        } 
    }

    private static Result<string> DoesContainsNumberEight(string cleanPhone)
    {
        if (cleanPhone.Length < 5)
            throw new InvalidDataException("PHONENUMBER_ERROR: phone number value can't below 4");

        string eight = "8";

        var thirdIdx = cleanPhone[2] == '8';

        var fourthIdx = cleanPhone[3] == '8';

        if (thirdIdx) 
        {
            return Result<string>.Success(eight + cleanPhone[3..]);
        }
        else if (fourthIdx)
        {
            return Result<string>.Success(eight + cleanPhone[4..]);
        }
        else
        {
            return Result<string>.Failure(PhoneNumberErrors.InvalidFormat());
        }
    }

    [GeneratedRegex(@"^[+\d\s-]+$")]
    private static partial Regex AllowNumeric();
}
// i love myself