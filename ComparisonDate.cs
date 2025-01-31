using System;

class ComparisonDate
{
    public static void Main()
    {
			//take input of date
            Console.Write("Enter the first date (yyyy-MM-dd): ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
			//take input of date
            Console.Write("Enter the second date (yyyy-MM-dd): ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            
            int result = firstDate.CompareTo(secondDate);
			//Compare the date
            if (result < 0)
                Console.WriteLine("The first date is before the second date.");
            else if (result > 0)
                Console.WriteLine("The first date is after the second date.");
            else
                Console.WriteLine("Both dates are the same.");
        
        
    }
}