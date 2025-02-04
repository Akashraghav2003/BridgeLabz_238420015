//using System;
//using System.ComponentModel;

//namespace OOPs_second
//{
//    internal class BankAccount
//    {
//        private static string bankName = "State Bank Of India";
//        private string accountHolderName;
//        private readonly int accountNumber;
//        private static int totalAccount = 0;

//        internal BankAccount()
//        {
//            Random random = new Random();
//            this.accountNumber = random.Next(1000, 10000);
//            totalAccount++;
//        }

//        // Public method to access private GetDetails()
//        public void SetDetails()
//        {
//            GetDetails(); // Calling private method inside a public method
//        }

//        // Private method for input
//        private void GetDetails()
//        {
//            Console.WriteLine("Please enter the account holder name: ");
//            accountHolderName = Console.ReadLine();
//        }

//        // Public method to access private static method
//        public static void ShowTotalAccounts()
//        {
//            GetTotalAccount(); // Calling private method inside a public method
//        }

//        private static void GetTotalAccount()
//        {
//            Console.WriteLine($"Total number of accounts: {totalAccount}");
//        }
//        public void GetDisplay()
//        {
//            Display();
//        }
//        private void Display()
//        {
//            Console.WriteLine($"Bank Name: {bankName}, Account Holder Name: {accountHolderName}, Account Number: {accountNumber}");
//        }

       

//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            BankAccount bankAccount = new BankAccount();
//            bankAccount.SetDetails(); // Using public method to access private method

//            BankAccount bankAccount1 = new BankAccount();
//            bankAccount1.SetDetails();

//            BankAccount.ShowTotalAccounts(); // Accessing private method via public method

//            bankAccount1.GetDisplay();
//            bankAccount.GetDisplay();
//        }
//    }


//}
