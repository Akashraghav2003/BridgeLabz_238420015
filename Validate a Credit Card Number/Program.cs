using System;
using System.Text.RegularExpressions;

class Program
{
    static bool ValidateCreditCard(string cardNumber)
    {
        string pattern = @"^(4\d{15}|5\d{15})$"; // Visa: 4xxxxxxx (16 digits), MasterCard: 5xxxxxxx (16 digits)
        return Regex.IsMatch(cardNumber, pattern);
    }

    static void Main()
    {
        string[] testCards = {
            "4111111111111111", // ✅ Valid Visa
            "5500000000000004", // ✅ Valid MasterCard
            "1234567812345678", // ❌ Invalid (doesn't start with 4 or 5)
            "411111111111111",  // ❌ Invalid (only 15 digits)
            "5105105105105106", // ✅ Valid MasterCard
            "4999999999999999"  // ✅ Valid Visa
        };

        foreach (var card in testCards)
        {
            Console.WriteLine($"{card} → {(ValidateCreditCard(card) ? "Valid" : "Invalid")}");
        }
    }
}
