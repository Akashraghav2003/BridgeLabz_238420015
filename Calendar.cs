// Create a program to display a calendar for a given month and year. 
// The program should take the month and year as input from the user and 
// display the calendar for that month. E.g. for 07 2005 user input, the program should display the calendar

using System;

namespace CalendarApp
{
    public class Calendar
    {
        // Method to get the name of the month
        public static string GetMonthName(int month)
        {
            string[] months = {
                "January", "February", "March", "April", "May", "June", 
                "July", "August", "September", "October", "November", "December"
            };
            return months[month - 1];
        }

        // Method to check if a year is a leap year
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        // Method to get the number of days in a month
        public static int GetDaysInMonth(int month, int year)
        {
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Adjust for February in case of leap year
            if (month == 2 && IsLeapYear(year))
            {
                return 29;
            }
            return daysInMonth[month - 1];
        }

        // Method to get the first day of the month using the Gregorian calendar algorithm
        public static int GetFirstDayOfMonth(int month, int year)
        {
            // Adjust month and year for the algorithm
            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (1 + x + 31 * m0 / 12) % 7;

            return d0;
        }

        // Method to display the calendar for a given month and year
        public static void DisplayCalendar(int month, int year)
        {
            string monthName = GetMonthName(month);
            int daysInMonth = GetDaysInMonth(month, year);
            int firstDay = GetFirstDayOfMonth(month, year);

            Console.WriteLine("Calendar for " + monthName + " " + year + "\n");
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            // Display indentation for the first day of the month
            for (int i = 0; i < firstDay; i++)
            {
                Console.Write("    ");
            }

            // Display the days of the month
            for (int day = 1; day <= daysInMonth; day++)
            {
                // Display the day in a 3-character wide field for proper alignment
                Console.Write(String.Format("{0,3} ", day));

                // Move to the next line after Saturday
                if ((firstDay + day) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            // Move to the next line after the last day
            Console.WriteLine();
        }

        // Main method
        public static void Main()
        {
            Console.WriteLine("Enter the month (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            // Display the calendar for the entered month and year
            DisplayCalendar(month, year);
        }
    }
}
