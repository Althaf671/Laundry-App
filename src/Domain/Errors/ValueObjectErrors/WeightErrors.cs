using src.Domain.Common;
using src.Domain.ValueObjects;

namespace src.Domain.Errors.ValueObjectErrors;
public static class WeightErrors
{
    private static readonly string Domain = nameof(Weight);

    public static Error UnitRequired() 
    {
        return new Error(
            "Weight.UnitRequired", "Weight unit can't be empty", Domain
        );
    }

    public static Error UnitMaxCharacters()
    {
        return new Error(
            "Weight.UnitMaxCharacters", "Unit maximum character is 7", Domain
        );
    }

    public static Error NotAllowedUnit()
    {
        return new Error(
            "Weight.NotAllowedUnit", "Only KG is allowed", Domain
        ); 
    }

    public static Error InvalidValue()
    {
        return new Error(
            "Weight.InvalidValue", "Value must be a positive or not exceed 100", 
            Domain
        );   
    }
}