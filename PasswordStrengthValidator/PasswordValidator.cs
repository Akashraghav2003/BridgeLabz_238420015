using System;
using System.Text.RegularExpressions;

namespace Security
{
    public class PasswordValidator
    {
        // Method to validate password strength
        public bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            // Check for minimum length, at least one uppercase letter, and one digit
            return password.Length >= 8 &&
                   Regex.IsMatch(password, @"[A-Z]") &&
                   Regex.IsMatch(password, @"\d");
        }
    }
}
