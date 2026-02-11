// See https://aka.ms/new-console-template for more information
using src.Domain.Common;
using src.Domain.ValueObjects;

Console.Write("Input email: ");
var email = Console.ReadLine();
var createdEmail = Email.Update(email!);
try
{
    if (createdEmail.IsFailure)
    {
        Console.WriteLine(createdEmail.Error);
    }
    if (createdEmail.IsSuccess)
    {
        Console.WriteLine(createdEmail);
    } 
}
catch (DomainException ex)
{
    Console.WriteLine($"FATAL_ERROR: {ex.Message}");
}

