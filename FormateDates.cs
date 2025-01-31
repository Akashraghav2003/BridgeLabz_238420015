using System;

class FormateDates
{
    public static void Main()
    {	//take current date
        DateTime dateTime = DateTime.Now;

	
		//dispaly the result
        Console.WriteLine("dd/MM/dd: " + dateTime.ToString("dd/MM/dd"));
		Console.WriteLine("yyyy-MM-dd: " + dateTime.ToString("yyyy-MM-dd"));
		Console.WriteLine("EEE,MMM,dd,yyyy: " + dateTime.ToString("EEE,MMM,dd,yyyy"));
        
    }

}