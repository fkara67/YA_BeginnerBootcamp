﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bank App");

Account account1 = new Account(1000);
account1.FirstName = "John";
account1.LastName = "Black";
account1.PhoneNumber = "1234567890";
account1.IBAN = "TR123654555";
//account1.Balance = 1000;
//account1.SetBalance(1000);

account1.Withdraw(1500);
account1.Withdraw(550);

Console.WriteLine(account1.GetBalance());

//Console.WriteLine(account1.Balance);


class Account
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string IBAN { get; set; }
    private decimal Balance { get; set; }

    public Account(decimal balance)
    {
        Balance = balance;
    }

    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        else if (Balance != 0)
        {
            System.Console.WriteLine($"Insufficient balance but you withdraw this amount: {Balance}");
            Balance = 0;
        }
        else
        {
            System.Console.WriteLine("Insufficient balance");
        }
    }

    public void SetBalance(decimal balance)
    {
        if (Balance <= 1000)
            Balance = balance;
    }

    public decimal GetBalance() //Geri dönüş tipi Decimal olan bir metot ile değiştirilecek
    {
        return Balance;
    }
}

