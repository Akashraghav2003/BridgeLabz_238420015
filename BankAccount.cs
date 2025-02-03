using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class BankAccount
    {
        public string AccountNumber;
        protected string AccountHolder;
        private double Balance;

        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        // Method to get the balance
        public double GetBalance()
        {
            return Balance;
        }

        // Method to set the balance
        public void SetBalance(double balance)
        {
            Balance = balance;
        }
    }
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountNumber, string accountHolder, double balance)
            : base(accountNumber, accountHolder, balance) { }

        public void DisplayAccountInfo()
        {
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Account Holder: " + AccountHolder);
            Console.WriteLine("Balance: " + GetBalance());
        }

        static void Main(string[] args)
        {
            // Creating an instance and testing
            SavingsAccount savings = new SavingsAccount("12345", "akash raghav", 1000.50);
            savings.DisplayAccountInfo();

            // Modifying balance using setter
            savings.SetBalance(1500000.55);
            Console.WriteLine("Updated Balance: " + savings.GetBalance());
        }
    }
}
