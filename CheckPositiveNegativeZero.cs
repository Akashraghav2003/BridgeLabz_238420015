//Write a program to check whether a number is positive, negative, or zero.

using System;

namespace Assignment4 {
    
    // Class to check if a number is positive, negative, or zero
    class CheckPositiveNegativeZero {
        
        // Method to check the number and return the result
        public int Check(int num) {
            if (num > 0) {
                return 1; // Positive number
            } else if (num < 0) {
                return -1; // Negative number
            } else {
                return 0; // Zero
            }
        }
        
        
        static void Main(String[] args) {
			//take user input 
            Console.Write("Enter the Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
			//call the Check method
            CheckPositiveNegativeZero pnz = new CheckPositiveNegativeZero();
            Console.WriteLine("Given input is: " + pnz.Check(num));
        }
    }
}
