using System;
using System.Text.RegularExpressions;

class Program
{
    static bool IsValidLicensePlate(string plate)
    {
        string pattern = @"^[A-Z]{2}\d{4}$";
        return Regex.IsMatch(plate, pattern);
    }

    static void Main()
    {
        string[] testPlates = { "AB1234", "A12345", "XY9999", "abc123", "ZZ0000", "B1234C" };

        foreach (var plate in testPlates)
        {
            Console.WriteLine($"License Plate: {plate}, Valid: {IsValidLicensePlate(plate)}");
        }
    }
}
