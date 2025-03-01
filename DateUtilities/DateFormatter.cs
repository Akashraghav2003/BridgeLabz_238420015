using System;
using System.Globalization;

namespace DateUtilities
{
    public class DateFormatter
    {
        // Converts date from "yyyy-MM-dd" to "dd-MM-yyyy"
        public string FormatDate(string inputDate)
        {
            if (string.IsNullOrWhiteSpace(inputDate))
                throw new ArgumentException("Input date cannot be null or empty.");

            DateTime date;
            if (DateTime.TryParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                return date.ToString("dd-MM-yyyy");
            }
            else
            {
                throw new FormatException("Invalid date format. Expected format: yyyy-MM-dd");
            }
        }
    }
}
