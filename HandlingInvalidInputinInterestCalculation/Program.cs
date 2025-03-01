namespace HandlingInvalidInputinInterestCalculation
{
	class Program
	{
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the rate: ");
                double rate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the year: ");
                int year = Convert.ToInt32(Console.ReadLine());

               double result =  SimpleIntrest.Intrest(amount, rate, year);

                Console.WriteLine("Intrest after {year} year is:" + result);
            }
            catch (SimpleIntrest ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}