using Lesson_01.Helpers;

namespace Lesson_01.Models;

public class Account
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string IBAN { get; set; }
    private decimal Balance { get; set; }

    public string Email { get; set; }
    public string Password { get; set; }

    Random random = new();

    public Account(string email, string password)
    {
        Balance = 100;
        Email = email.ToLower();
        Password = password;
    }

    public Account(decimal balance, string email, string password, string firstName, string lastName, string phoneNumber)
    {
        Balance = Math.Min(balance, 1000);

        Email = email.ToLower();
        Password = password;

        FirstName = firstName;
        LastName = lastName;

        PhoneNumber = phoneNumber;

        IBAN = $"TR{random.Next(100_000_000, 999_999_999)}";

        Console.WriteLine($"{FirstName} Account created with IBAN: {IBAN}");
    }

    public decimal GetBalance()
    {
        return Balance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
    public decimal Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            return 0;
        }
        else if (Balance >= amount)
        {
            Balance -= amount;

            return amount;
        }
        else if (Balance != 0)
        {
            decimal tempBalance = Balance;
            Balance = 0;
            return tempBalance;
        }
        else
        {
            return 0;
        }
    }
}