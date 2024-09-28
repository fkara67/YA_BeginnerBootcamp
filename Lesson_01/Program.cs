using System.Data.Common;
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

string loggedInEmail = "";
bool isLoggedIn = false;

WriteLoginMenu();
string choise = Console.ReadLine();

if (choise == "1")
{
    Console.WriteLine("Enter your Email:");
    string email = Console.ReadLine();

    Console.WriteLine("Enter your Password:");
    string password = Console.ReadLine();

    LoginAccount(email, password);
}



void WriteLoginMenu()
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1 - Login");
    Console.WriteLine("2 - Sign Up");
}

void WriteMainMenu()
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1 - Deposit");
    Console.WriteLine("2 - Withdraw");
    Console.WriteLine("3 - Transfer");
    Console.WriteLine("4 - Log Out");
}

void TransferMoney(Account sender, Account receiver, decimal amount)
{
    decimal sendAmount = sender.Withdraw(amount);
    receiver.Deposit(sendAmount);
}

void LoginAccount(string email, string password)
{
    for (int i = 0; i < accounts.Count; i++)
    {
        if (accounts[i].Email == email)
        {
            if (accounts[i].Password == password)
            {
                isLoggedIn = true;
                loggedInEmail = email;
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
        else
        {
            Console.WriteLine("Invalid Email");
        }
    }
}