using System;

class DateArithmetic
{
    public static void Main()
    {
            //dispaly the message
            Console.Write("Enter a date (yyyy-MM-dd): ");
            //take input of date
			DateTime inputDate = DateTime.Parse(Console.ReadLine());
        
            // Add 7 days, 1 month, and 2 years
            DateTime modifiedDate = inputDate.AddDays(7).AddMonths(1).AddYears(2);
            
            // Subtract 3 weeks (21 days)
            modifiedDate = modifiedDate.AddDays(-21);
   
            Console.WriteLine("Modified Date: " + modifiedDate.ToString("yyyy-MM-dd"));
        
      
        
    }

}