using Lesson_01.Models;


Console.WriteLine("Bank App");

List<Account> accounts = new();

Account account1 = new(300); //300
account1.FirstName = "John";
account1.LastName = "Doe";
account1.PhoneNumber = "123456789";
account1.IBAN = "TR123456789";
accounts.Add(account1);

Account account2 = new(1000); //1000
account2.FirstName = "Jane";
account2.LastName = "Doe";
account2.PhoneNumber = "987654321";
account2.IBAN = "TR987654321";
accounts.Add(account2);

TransferMoney(account1, account2, 500);

Console.WriteLine($"John's Balance: {account1.GetBalance()}");
Console.WriteLine($"Jane's Balance: {account2.GetBalance()}");

// account1.Withdraw(750);
// account1.Withdraw(300);
// account1.Withdraw(10000);
// account1.Withdraw(750);

Console.WriteLine($"Balance: {account1.GetBalance()}");

void TransferMoney(Account sender, Account receiver, decimal amount)
{
    decimal sendAmount = sender.Withdraw(amount);
    receiver.Deposit(sendAmount);
}