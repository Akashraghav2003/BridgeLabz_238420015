using System;

namespace Banking
{
    public class BankAccount
    {
        private double balance;

        // Constructor to initialize the balance
        public BankAccount(double initialBalance = 0)
        {
            if (initialBalance < 0)
                throw new ArgumentException("Initial balance cannot be negative.");

            balance = initialBalance;
        }

        // Deposit method to add money to the balance
        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");

            balance += amount;
        }

        // Withdraw method to reduce balance
        public bool Withdraw(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive.");

            if (amount > balance)
                return false; // Withdrawal fails if insufficient funds

            balance -= amount;
            return true;
        }

        // GetBalance method to return the current balance
        public double GetBalance()
        {
            return balance;
        }
    }
}
