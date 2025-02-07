using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAnd_AccountHolders
{
    internal class Customer
    {
        private String accountHolderName;
        private String accountnumber;
        private int balance { get; set; }

        public Customer(String accountHolderName, String accountnumber, int balance)
        {
            this.accountHolderName = accountHolderName;
            this.accountnumber = accountnumber;
            this.balance = balance;
        }
        public void ViewBalance()
        {
            Console.WriteLine($"Total Balance of Account {balance}");
        }

        public void CustomerSwitchCase()
        {
            Console.WriteLine("Choose the operation");
            Console.WriteLine("1.View the bank balance \n 2.Exits");
            int operation = Convert.ToInt32( Console.ReadLine() );

            while (operation > 0)
            {
                switch (operation)
                {
                    case 1:
                        ViewBalance();
                        break;
                    case 2:
                        return;
                    default:
                        Console.WriteLine("Choose the write operation.");
                        break;
                }

            }
        }
    }
}
