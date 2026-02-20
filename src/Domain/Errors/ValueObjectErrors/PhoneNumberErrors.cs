using src.Domain.Common;
using src.Domain.ValueObjects;

namespace src.Domain.Errors.ValueObjectErrors;
public static class PhoneNumberErrors
{
    private static readonly string _domain = nameof(PhoneNumber);

    public static Error ValueRequired()
    {
        return new Error(
            "PhoneNumber.ValueRequired", "Phone number value can't be empty",
            _domain
        );
    }

    public static Error InvalidLength()
    {
        return new Error(
            "PhoneNumber.InvalidLength", "Phone number length must between 10-25",
            _domain
        );
    }

    public static Error InvalidFormat()
    {
        return new Error(
            "PhoneNumber.InvalidFormat", "Phone number format is not supported",
            _domain
        );
    }
}