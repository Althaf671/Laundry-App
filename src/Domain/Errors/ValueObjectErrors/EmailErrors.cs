using System.ComponentModel.DataAnnotations;
using src.Domain.Common;
using src.Domain.ValueObjects;

namespace src.Domain.Errors.ValueObjectErrors;
public static class EmailErrors
{
    private static readonly string Domain = nameof(Email);

    public static Error Empty(string action) 
    {
        var error = new Error(
            "Email.Empty", "Email can't be empty", Domain, action
        );

        return error;
    }

    public static Error InvalidFormat(string action)  
    {
        var error = new Error(
            "Email.InvalidFormat", "Email format is invalid", Domain, action
        );

        return error;
    }

    public static Error ExceedCharactersLimit(string action)  
    {
        var error = new Error(
            "Email.ExceedCharactersLimit", "Email reach maxium charater limit", 
            Domain, action
        );

        return error;
    }
}