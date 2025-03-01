namespace HandlingDivisionInputErrors
{
	class Program
	{
        static void Main(string[] args)
        {
            Division div = new Division(); 
            try
            {
                Console.Write("Enter the divident:");
                double divident = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the divisor: ");
                double divisor = Convert.ToDouble(Console.ReadLine());

               double result =  div.divide(divident, divisor);

                Console.WriteLine("Result after divide: " + result );
            }catch(FormatException)
            {
                Console.WriteLine("Enter the Correct datatype value: " );
            }catch (DivideByZeroException)
            {
                Console.WriteLine("Divisor should not be zero");
            }
            
        }
    }
}