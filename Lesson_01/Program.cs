
using Lesson_01.Models;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bank App");

List<Account> accounts = new();

Account account1 = new Account(1000);
account1.FirstName = "John";
account1.LastName = "Black";
account1.PhoneNumber = "1234567890";
account1.IBAN = "TR123654555";

Account account2 = new();
account2.FirstName = "Jane";
account2.LastName = "Doe";
account2.PhoneNumber = "987654321";
account2.IBAN = "TR987654321";
accounts.Add(account2);

string depositIBAN = "TR987654321";
decimal depositAmount = 750;

for (int i = 0; i < accounts.Count; i++)
{
    if (accounts[i].IBAN == depositIBAN)
    {
        accounts[i].Deposit(depositAmount);
    }
}

Console.WriteLine($"John's Balance: {account1.GetBalance()}");
Console.WriteLine($"Jane's Balance: {account2.GetBalance()}");

//account1.Withdraw(1500);
//account1.Withdraw(550);




