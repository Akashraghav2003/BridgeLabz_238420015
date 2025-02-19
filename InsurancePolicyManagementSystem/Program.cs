namespace InsurancePolicyManagementSystem
{
	class Program
	{
        static void Main()
        {
            PolicyManagementSystem pms = new PolicyManagementSystem();

            pms.AddPolicy(new Policy("P1001", "Alice", "Health", DateTime.Today.AddDays(10)));
            pms.AddPolicy(new Policy("P1002", "Bob", "Auto", DateTime.Today.AddDays(40)));
            pms.AddPolicy(new Policy("P1003", "Charlie", "Home", DateTime.Today.AddDays(25)));
            pms.AddPolicy(new Policy("P1001", "Alice", "Health", DateTime.Today.AddDays(10))); // Duplicate

            Console.WriteLine("All Unique Policies:");
            foreach (var policy in pms.GetAllPolicies()) Console.WriteLine(policy);

            Console.WriteLine("\nPolicies Expiring Soon (Next 30 Days):");
            foreach (var policy in pms.GetExpiringSoon()) Console.WriteLine(policy);

            Console.WriteLine("\nPolicies with Health Coverage:");
            foreach (var policy in pms.GetPoliciesByCoverage("Health")) Console.WriteLine(policy);

            Console.WriteLine("\nDuplicate Policies:");
            foreach (var policy in pms.GetDuplicatePolicies()) Console.WriteLine(policy);
        }
    }
}