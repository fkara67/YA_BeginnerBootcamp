using Lesson_01.Helpers;

namespace Lesson_01.Models;

public class Account
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string IBAN { get; set; }
    private decimal Balance { get; set; }
    // public decimal Balance { get; private set; }

    public string Email { get; set; }
    public string Password { get; set; }

    //15
    //15/1

    Random random = new();


    public Account(string email, string password)
    {
        Balance = 100;
        Email = email;
        Password = password;
    }

    public Account(decimal balance, string email, string password, string firstName, string lastName, string phoneNumber)
    {
        if (balance <= 1000)
            Balance = balance;

        Email = email.ToLower();
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;

        IBAN = $"TR{random.Next(100_000_000, 999_999_999)}";

        Console.WriteLine($"{FirstName} Account created with IBAN: {IBAN}");
    }

    // public void SetBalance(decimal balance)
    // {
    //     if (balance <= 1000)
    //         Balance = balance;
    // }

    public decimal GetBalance() //Geri dönüş tipi Decimal olan bir metot ile değiştirilecek
    {
        return Balance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
    public decimal Withdraw(decimal amount) //1500
    {
        //Balance: 1000
        //Amount: -1500
        if (amount <= 0)
        {
            return 0;
        }
        else if (Balance >= amount)
        {
            Balance -= amount;

            // Console.WriteLine($"Withdraw successful, new balance is: {Balance}");

            return amount;
        }
        else if (Balance != 0)
        {
            // Console.WriteLine($"Insufficient balance but you withdraw this amount: {Balance}");
            decimal tempBalance = Balance; //1000
            Balance = 0; //0
            return tempBalance;
        }
        else
        {
            // Console.WriteLine("Insufficient balance");
            return 0;
        }
    }
}