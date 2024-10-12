using Lesson_01.Helpers;
using Lesson_01.Models;


Console.WriteLine("Bank App");

List<Account> accounts = new();

Account account1 = new(300, "john@gmail.com", "123456", "John", "Doe", "123456789");
accounts.Add(account1);

Account account2 = new(1000, "jane@gmail.com", "4321", "Jane", "Doe", "987654321");
accounts.Add(account2);

Account loggedInAccount = null;
bool isLoggedIn = false;

while (true)
{
    if (!isLoggedIn)
    {
        string choise = InputHelper.GetInput(WriteLoginMenu());

        if (choise == "1")
        {
            string email = InputHelper.GetInput("Enter your Email:");

            string password = InputHelper.GetInput("Enter your Password:");

            LoginAccount(email, password);
        }

        else if (choise == "2")
        {
            string email = InputHelper.GetInput("Enter your Email:");

            string password = InputHelper.GetInput("Enter your Password:");

            string firstName = InputHelper.GetTextOnlyInput("Enter your First Name:");

            string lastName = InputHelper.GetTextOnlyInput("Enter your Last Name:");

            string phoneNumber = InputHelper.GetNumberOnlyInput("Enter your Phone Number:");

            Account accountToAdd = new(100, email, password, firstName, lastName, phoneNumber);

            accounts.Add(accountToAdd);

            Console.WriteLine("Account created successfully");
        }
    }
    else
    {
        string choise = InputHelper.GetInput(WriteMainMenu());

        if (choise == "1")
        {
            decimal amount = Convert.ToDecimal(
                InputHelper.GetNumberOnlyInput("Enter the amount you want to deposit:")
                );

            if (loggedInAccount != null && amount > 0)
            {
                loggedInAccount.Deposit(amount);
                Console.WriteLine($"Your new balance is: {loggedInAccount.GetBalance()}");
            }
            else
            {
                Console.WriteLine("Invalid amount, please enter a positive number");
            }
        }
        else if (choise == "2")
        {
            decimal withdrawAmount = Convert.ToDecimal(InputHelper.GetNumberOnlyInput("Enter the amount you want to withdraw:"));

            decimal withdrawResult = loggedInAccount.Withdraw(withdrawAmount);

            if (withdrawResult == 0)
            {
                Console.WriteLine("Insufficient balance");
            }
            else if (withdrawResult == withdrawAmount)
            {
                Console.WriteLine($"Withdraw successful, new balance is: {loggedInAccount.GetBalance()}");
            }
            else
            {
                Console.WriteLine($"Insufficient balance but you withdraw this amount: {withdrawResult}");
            }
        }
        else if (choise == "3")
        {
            string iban = InputHelper.GetInput("Enter the IBAN you want to transfer to:");

            decimal withdrawAmount = Convert.ToDecimal(InputHelper.GetNumberOnlyInput("Enter the amount you want to transfer:"));

            Account receiverAccount = accounts.FirstOrDefault(a => a.IBAN == iban);

            if (receiverAccount == null)
            {
                Console.WriteLine("Receiver account not found");
            }
            else
            {
                TransferMoney(loggedInAccount, receiverAccount, withdrawAmount);
            }

        }
        else if (choise == "4")
        {
            decimal balance = loggedInAccount.GetBalance();
            Console.WriteLine($"Your balance is: {balance}");
        }
        else if (choise == "5")
        {
            string currentPassword = InputHelper.GetInput("Enter your current password:");

            if (currentPassword != loggedInAccount.Password)
            {
                Console.WriteLine("Password is incorrect, sign in again to change your password");
                loggedInAccount = null;
                isLoggedIn = false;
                continue;
            }

            string newPassword = InputHelper.GetInput("Enter your new password:");

            string newPasswordAgain = InputHelper.GetInput("Enter your new again password:");

            if (newPassword != newPasswordAgain)
            {
                Console.WriteLine("Passwords do not match");
            }

            else if (newPassword == currentPassword)
            {
                Console.WriteLine("New password cannot be the same as the old one.");
            }
            else
            {
                loggedInAccount.Password = newPassword;
                Console.WriteLine("Password changed successfully");
            }

        }
        else if (choise == "6")
        {
            isLoggedIn = false;
            loggedInAccount = null;
        }
    }
}




string WriteLoginMenu()
{
    return "1 - Login\n2 - Sign Up\nChoose an option:";
}

string WriteMainMenu()
{
    return "1 - Deposit\n2 - Withdraw\n3 - Transfer\n4 - Show Balance\n5 - Change Password\n6 - Log Out\nChoose an option:";
}

void TransferMoney(Account sender, Account receiver, decimal amount)
{
    decimal sendAmount = sender.Withdraw(amount);
    receiver.Deposit(sendAmount);

    Console.WriteLine($"Transfer successful, new balance is: {sender.GetBalance()}");
}

void LoginAccount(string email, string password)
{
    Account account = accounts.FirstOrDefault(a => a.Email == email);

    if (account == null)
    {
        Console.WriteLine("Account does not exist");
    }
    else if (account.Password != password)
    {
        Console.WriteLine("Password is incorrect");
    }
    else
    {
        isLoggedIn = true;
        loggedInAccount = account;
        Console.WriteLine("Login successful");
    }

}