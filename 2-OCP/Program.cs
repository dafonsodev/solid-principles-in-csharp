using _2_OCP;
using _2_OCP.Following;
using _2_OCP.Following.Extensions;
using _2_OCP.Violating;

// Bad Example (Violating OCP)
DebitInAccountBad debitBad = new()
{
    NumberAccount = "12345",
    Amount = 100
};
var resultBad = debitBad.Process(DebitsType.CheckingAccount, debitBad.NumberAccount, debitBad.Amount);
Console.WriteLine("Bad Example (Violating OCP)");
Console.WriteLine($"{resultBad}: Your balance is {debitBad.Balance}");
// Bad Example (Violating OCP)

Console.WriteLine();

// Good Example(Following OCP)
DebitInAccountGood debitGood = new()
{
    NumberAccount = "12345",
    Amount = 200
};
var resultGood = debitGood.ToDebitInCheckingAccount();
Console.WriteLine("Good Example (Violating OCP)");
Console.WriteLine($"{resultGood}: Your balance is {debitGood.Balance}");
// Good Example(Following OCP)