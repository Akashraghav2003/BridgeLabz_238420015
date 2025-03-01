using System;
using System.Text.RegularExpressions;

class Program
{
    static bool ValidateIPv4(string ipAddress)
    {
        string pattern = @"^(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\."
                       + @"(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\."
                       + @"(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\."
                       + @"(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)$";

        return Regex.IsMatch(ipAddress, pattern);
    }

    static void Main()
    {
        string[] testIPs = {
            "192.168.1.1",     // ✅ Valid
            "255.255.255.255", // ✅ Valid
            "256.100.50.25",   // ❌ Invalid (256 > 255)
            "192.168.01.1",    // ❌ Invalid (leading zero in 01)
            "192.168.1",       // ❌ Invalid (only 3 parts)
            "abc.def.ghi.jkl"  // ❌ Invalid (not numbers)
        };

        foreach (var ip in testIPs)
        {
            Console.WriteLine($"{ip} → {(ValidateIPv4(ip) ? "Valid" : "Invalid")}");
        }
    }
}
