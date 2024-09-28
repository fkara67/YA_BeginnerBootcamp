using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_01.Models
{
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

        public Account()
        {
            Balance = 100;
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

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public decimal GetBalance() //Geri dönüş tipi Decimal olan bir metot ile değiştirilecek
        {
            return Balance;
        }
    }
}
