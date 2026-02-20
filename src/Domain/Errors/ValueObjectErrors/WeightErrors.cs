using src.Domain.Common;
using src.Domain.ValueObjects;

namespace src.Domain.Errors.ValueObjectErrors;
public static class WeightErrors
{
    private static readonly string _domain = nameof(Weight);

    public static Error UnitRequired() 
    {
        return new Error(
            "Weight.UnitRequired", "Weight unit can't be empty", _domain
        );
    }

    public static Error UnitMaxCharacters()
    {
        return new Error(
            "Weight.UnitMaxCharacters", "Unit maximum character is 7", _domain
        );
    }

    public static Error NotAllowedUnit()
    {
        return new Error(
            "Weight.NotAllowedUnit", "Only KG is allowed", _domain
        ); 
    }

    public static Error InvalidValue()
    {
        return new Error(
            "Weight.InvalidValue", "Value must be a positive or not exceed 100", 
            _domain
        );   
    }
}