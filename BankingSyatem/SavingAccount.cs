using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class SavingAccount: BankAccount
    {
        public SavingAccount(string accountNumber, string holderName, double initialBalance)
            : base(accountNumber, holderName, initialBalance) { }

        public override double CalculateInterest()
        {
            return Balance * 0.04; // 4% interest annually
        }
    }
}
