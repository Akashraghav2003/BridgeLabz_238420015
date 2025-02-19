namespace BankingSystem
{
	class Program
	{
        static void Main()
        {
            Banking bank = new Banking();

            bank.AddAccount(101, 1500);
            bank.AddAccount(102, 500);
            bank.AddAccount(103, 2000);

            bank.WithdrawRequest(101, 300);
            bank.WithdrawRequest(102, 600);
            bank.WithdrawRequest(103, 1000);

            bank.ProcessWithdrawals();
            bank.DisplaySortedAccounts();
        }
    }
}