using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class CurrentAccount : BankAccount, ILonable
    {
        private double loanLimit;

        public CurrentAccount(string accountNumber, string holderName, double initialBalance, double loanLimit)
            : base(accountNumber, holderName, initialBalance)
        {
            this.loanLimit = loanLimit;
        }

        public override double CalculateInterest()
        {
            return 0; // No interest for current accounts
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 2 + loanLimit; // Loan eligibility is twice the balance plus loan limit
        }

        public void ApplyForLoan(double amount)
        {
            if (amount <= CalculateLoanEligibility())
            {
                Console.WriteLine($"Loan of {amount:C} approved.");
            }
            else
            {
                Console.WriteLine($"Loan amount exceeds eligibility of {CalculateLoanEligibility():C}.");
            }
        }
    }
}
