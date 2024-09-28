
namespace Lesson_01.Models;

public class Account
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string IBAN { get; set; }
    private decimal Balance { get; set; } //1000

    //15
    //15/1

    public Account()
    {
        Balance = 100;
    }

    public Account(decimal balance)
    {
        if (balance <= 1000)
            Balance = balance;
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
        //Amount: 1500
        if (Balance >= amount)
        {
            Balance -= amount;
            return amount;
        }
        else if (Balance != 0)
        {
            Console.WriteLine($"Insufficient balance but you withdraw this amount: {Balance}");
            decimal tempBalance = Balance;
            Balance = 0;
            return tempBalance;
        }
        else
        {
            System.Console.WriteLine("Insufficient balance");
            return 0;
        }
        //End Balance: 1000

    }
}
