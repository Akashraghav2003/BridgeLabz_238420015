
//7.Write a program to generate a six-digit OTP number using Math.Random() method.
 //Validate the numbers are unique by generating the OTP number 10 times and ensuring all the 10 OTPs are not the same


using System;

namespace OTPGeneration{
    public static class OTPGenerator{
        // Method to generate a 6-digit OTP number
        public static int GenerateOTP(){
            Random random = new Random();
            // Generate a random number between 100000 and 999999 (6-digit number)
            return random.Next(100000, 1000000);
        }

        // Method to ensure OTP numbers are unique
        public static bool AreUniqueOTPs(int[] otps){
            // Loop through the OTPs array and compare each with every other OTP to check for uniqueness
            for (int i = 0; i < otps.Length; i++){
                for (int j = i + 1; j < otps.Length; j++){
                    if (otps[i] == otps[j])  // If two OTPs are the same, return false{
                        return false;
                    }
                }
            }
            // If no duplicates found, return true
            return true;
        }

        // Main method to generate 10 OTPs and validate uniqueness
        public static void Main(){
            int[] otps = new int[10];  // Array to store 10 OTP numbers

            // Generate 10 OTPs
            for (int i = 0; i < 10; i++){
                otps[i] = GenerateOTP();
                Console.WriteLine("Generated OTP " + (i + 1) + ": " + otps[i]);
            }

            // Check if OTPs are unique
            bool areUnique = AreUniqueOTPs(otps);

            // Display result
            if (areUnique){
                Console.WriteLine("\nAll OTP numbers are unique.");
            }else{
                Console.WriteLine("\nThere are duplicate OTP numbers.");
            }
        }
    }
}
