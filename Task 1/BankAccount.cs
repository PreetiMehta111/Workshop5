using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class BankAccount
    {
        private string accountNumber;
        private double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // Public getter, private setter; no negative or zero balances allowed
        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Balance cannot be Zero or Negative.");
                }
                balance = value;
            }
        }

        public BankAccount(string accountNumber, double openingBalance)
        {
            this.accountNumber = accountNumber;
            Balance = openingBalance; 
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount should be positive.");
                return;
            }

            balance += amount;
            Console.WriteLine($"Deposited {amount}. New balance: {balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount Should be Positive.");
                return;
            }

            if (amount > balance)
            {
                Console.WriteLine("Insufficient Fund.");
                return;
            }

            balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New balance: {balance}");
        }
    }
}