using System;
using System.Text.RegularExpressions;

class Program
{
    static bool ValidateSSN(string ssn)
    {
        string pattern = @"^\d{3}-\d{2}-\d{4}$"; // Matches "123-45-6789"
        return Regex.IsMatch(ssn, pattern);
    }

    static void Main()
    {
        string[] testSSNs = {
            "123-45-6789",  
            "123456789",    
            "12-345-6789",  
            "000-00-0000",  
            "987-65-4321"   
        };

        foreach (var ssn in testSSNs)
        {
            Console.WriteLine($"{ssn} → {(ValidateSSN(ssn) ? "Valid" : "Invalid")}");
        }
    }
}
