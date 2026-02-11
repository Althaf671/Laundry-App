using src.Domain.Common;

namespace src.Domain.Errors;
public class CommonError
{
    public static Error OperationFailed(string domain,string action)
    {
        var error = new Error(
            $"{domain}.OperationFailed", $"Operation {action} failed", 
            $"{domain}", $"{action}"
        );

        return error;
    }

    public static Error RequiredField(string domain, string action)
    {
        var error = new Error(
            $"{domain}.RequiredField", $"{action} must have a value", 
            $"{domain}", $"{action}"
        );

        return error;
    }
}