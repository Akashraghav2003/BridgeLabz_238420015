using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        protected double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            private set { accountNumber = value; }
        }

        public string HolderName
        {
            get { return holderName; }
            private set { holderName = value; }
        }

        public double Balance
        {
            get { return balance; }
            protected set { balance = value; }
        }

        public BankAccount(string accountNumber, string holderName, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount.");
            }
        }

        public abstract double CalculateInterest();

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Account: {accountNumber}, Holder: {holderName}, Balance: {balance:C}");
        }
    }
}
