using System;

class DateAndTimes
{
    static void Main()
    {
        DateTimeOffset currentTime = DateTimeOffset.UtcNow;

        // Define time zones
        TimeZoneInfo gmt = TimeZoneInfo.FindSystemTimeZoneById("GMT");
        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        // Convert current time to different time zones
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(currentTime, gmt);
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(currentTime, ist);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(currentTime, pst);

        // Display the times
        Console.WriteLine("Current Time in GMT: " + gmtTime);
        Console.WriteLine("Current Time in IST: " + istTime);
        Console.WriteLine("Current Time in PST: " + pstTime);
    }
}
