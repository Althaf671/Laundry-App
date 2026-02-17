namespace src.Domain.Exceptions;

public sealed class InvalidValueObjectState : DomainException
{
    public InvalidValueObjectState(string message) : base(message)
    {
    }
}