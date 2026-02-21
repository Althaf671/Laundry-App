// See https://aka.ms/new-console-template for more information
// using src.Domain.Common;
// using src.Domain.Entity;
// using src.Domain.ValueObjects;

using src.Domain.Common;
using src.Domain.ValueObjects;



// Money test
Console.Write("Input money value: ");
var value = Console.ReadLine();
var parsed = decimal.Parse(value!);
Console.Write("Input currency: ");
var currency = Console.ReadLine();

var money = Money.Create(parsed, currency!);
if (money.IsFailure)
    Console.WriteLine($"RESULT_ERROR: {money.Error}");

if (money.IsSuccess)
    Console.WriteLine($"RESULT_SUCCESS: {money.Value!.Currency} {money.Value!.Value}");


// Phone number test
// Scenario 1: empty input 
// Scenario 2: phone below min length 
// Scenario 3: phone above max length 
// Scenario 4: phone starts without 08 
// Scenario 5: phone starts with 08 
// Console.WriteLine("Input phone number: ");
// var input = Console.ReadLine();
// var newPhone = PhoneNumber.Create(input!);
// if (newPhone.IsFailure)
//     Console.WriteLine($"RESULT_ERROR: {newPhone.Error}");

// if (newPhone.IsSuccess)
//     Console.WriteLine($"RESULT_SUCCESS: {newPhone.Value!.Value}");



// Weight VO test
// Console.WriteLine("Input weight: ");
// var input = Console.ReadLine();
// var weight = decimal.Parse(input!);

// Console.WriteLine("Input unit: ");
// var unit = Console.ReadLine();
// var weightUnit = Weight.Create(weight, unit!);

// if (weightUnit.IsFailure)
//     Console.WriteLine($"RESULT_ERROR: {weightUnit.Error}");
    
// if (weightUnit.IsSuccess)
//     Console.WriteLine(
//         $"RESULT_SUCCESS: weight = {weightUnit.Value!.Value}, unit: {weightUnit.Value.Unit}");

// Email VO test
// Console.Write("Input email: ");
// var email = Console.ReadLine();
// var createdEmail = Email.Create(email!);
// try
// {
//     if (createdEmail.IsFailure)
//     {
//         Console.WriteLine(createdEmail.Error);
//     }
//     if (createdEmail.IsSuccess)
//     {
//         Console.WriteLine(createdEmail.Value!.Value);
//     } 
// }
// catch (DomainException ex)
// {
//     Console.WriteLine($"ERROR: {ex.Message}");
// }

// Console.Write("Isi ini: ");
// var a = Console.ReadLine();
// Console.WriteLine(a);