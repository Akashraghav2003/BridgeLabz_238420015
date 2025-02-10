using BankingSystem;  // Correct namespace

internal class Program
{
    static void ProcessAccounts(List<BankAccount> accounts)
    {
        foreach (var account in accounts)
        {
            account.DisplayDetails();
            Console.WriteLine($"Interest Earned: {account.CalculateInterest():C}");

            if (account is ILonable loanableAccount)
            {
                Console.WriteLine($"Loan Eligibility: {loanableAccount.CalculateLoanEligibility():C}");
                loanableAccount.ApplyForLoan(5000); // Example loan application
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>
        {
            new SavingAccount("123", "Vikram singh", 10000),
            new CurrentAccount("456", "Akash Singh", 20000, 5000)
        };

        ProcessAccounts(accounts);
    }
}
