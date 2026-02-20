using System.ComponentModel.DataAnnotations;
using src.Domain.Common;
using src.Domain.ValueObjects;

namespace src.Domain.Errors.ValueObjectErrors;
public static class EmailErrors
{
    private static readonly string _domain = nameof(Email);

    public static Error ValueRequired() 
    {
        return new Error(
            "Email.ValueRequired", "Email value can't be empty", _domain
        );
    }

    public static Error InvalidFormat()  
    {
        return new Error(
            "Email.InvalidFormat", "Email format is invalid", _domain
        );
    }

    public static Error ExceedCharactersLimit()  
    {
        return new Error(
            "Email.ExceedCharactersLimit", "Email reach maxium charater limit", 
            _domain
        );
    }

    public static Error UnknownDomain()
    {
        return new Error(
            "Email.UnknownDomain", "Email domain is not registered", 
            _domain
        );
    }
}

