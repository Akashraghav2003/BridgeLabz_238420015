using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class Banking
    {
        private Dictionary<int, double> accountBalances = new Dictionary<int, double>();
        private SortedDictionary<int, double> sortedAccounts = new SortedDictionary<int, double>();
        private Queue<(int, double)> withdrawalQueue = new Queue<(int, double)>();

        public void AddAccount(int accountNumber, double balance)
        {
            accountBalances[accountNumber] = balance;
            sortedAccounts[accountNumber] = balance;
        }

        public void WithdrawRequest(int accountNumber, double amount)
        {
            if (accountBalances.ContainsKey(accountNumber))
                withdrawalQueue.Enqueue((accountNumber, amount));
            else
                Console.WriteLine($"Account {accountNumber} not found.");
        }

        public void ProcessWithdrawals()
        {
            while (withdrawalQueue.Count > 0)
            {
                var (account, amount) = withdrawalQueue.Dequeue();
                if (accountBalances[account] >= amount)
                {
                    accountBalances[account] -= amount;
                    sortedAccounts[account] = accountBalances[account];
                    Console.WriteLine($"Withdrawal of ${amount:0.00} from Account {account} successful.");
                }
                else
                {
                    Console.WriteLine($"Insufficient balance in Account {account}.");
                }
            }
        }
        public void DisplaySortedAccounts()
        {
            Console.WriteLine("\nAccounts Sorted by Balance:");
            foreach (var account in sortedAccounts.OrderBy(a => a.Value))
                Console.WriteLine($"Account {account.Key}: ${account.Value:0.00}");
        }
    }
}
