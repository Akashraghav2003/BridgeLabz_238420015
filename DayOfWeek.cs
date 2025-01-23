using System;

class DayOfWeek{

    static void Main(string[] args){
       
        // Parse input arguments for month, day, and year
        int month = int.Parse(args[0]);
        int day = int.Parse(args[1]);
        int year = int.Parse(args[2]);

        // Validate the month input
        if (month < 1 || month > 12)
        {
            Console.WriteLine("Month must be between 1 and 12.");
            return;
        }

        // Validate the day input
        if (day < 1 || day > 31){
            Console.WriteLine("Day must be between 1 and 31.");
            return;
        }

        // Calculate the adjusted year based on the month
        int yearOffset = year - (14 - month) / 12;

        // Calculate the leap year adjustments
        int leapYearAdjust = yearOffset + yearOffset / 4 - yearOffset / 100 + yearOffset / 400;

        // Adjust the month to fit the formula
        int adjustedMonth = month + 12 * ((14 - month) / 12) - 2;

        // Calculate the day of the week
        int weekday = (day + leapYearAdjust + (31 * adjustedMonth) / 12) % 7;

        // Output the result
        Console.WriteLine("Day of the week: " + weekday);
    }
}
