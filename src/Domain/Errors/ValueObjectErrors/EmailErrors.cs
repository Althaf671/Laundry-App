using System.ComponentModel.DataAnnotations;
using src.Domain.Common;
using src.Domain.ValueObjects;

namespace src.Domain.Errors.ValueObjectErrors;
public static class EmailErrors
{
    private static readonly string Domain = nameof(Email);

    public static Error ValueRequired() 
    {
        return new Error(
            "Email.ValueRequired", "Email value can't be empty", Domain
        );
    }

    public static Error InvalidFormat()  
    {
        return new Error(
            "Email.InvalidFormat", "Email format is invalid", Domain
        );
    }

    public static Error ExceedCharactersLimit()  
    {
        return new Error(
            "Email.ExceedCharactersLimit", "Email reach maxium charater limit", 
            Domain
        );
    }

    public static Error UnknownDomain()
    {
        return new Error(
            "Email.UnknownDomain", "Email domain is not registered", 
            Domain
        );
    }
}

