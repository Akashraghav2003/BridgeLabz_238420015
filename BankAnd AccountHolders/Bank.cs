using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAnd_AccountHolders
{
    internal class Bank
    {
        
        private List<Customer> customers = new List<Customer>();

        

        public void OpenAccount()
        {
            Console.WriteLine("Enter the user name");
            string accountHolderName = Console.ReadLine();
            Console.WriteLine("Enter the Account Number");
            String accountNumber  = Console.ReadLine();
            Console.WriteLine("Enter the initial balane to summit");
            int balance = Convert.ToInt32(Console.ReadLine());

            Customer customer = new Customer (accountHolderName, accountNumber, balance);
            customers.Add(customer);
            customer.CustomerSwitchCase();

        }

        public void Deposit()
        {
            Console.WriteLine("write the balance to deposite");
            int deposite = Convert.ToInt32(Console.ReadLine());

            if(deposite > 0)
            {
                balance += deposite;
            }
            else
            {
                Console.WriteLine("Amount is invalid. ");
            }
        }

       

    }
}  