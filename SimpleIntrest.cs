//Write a program to input the Principal, Rate, and Time values and calculate Simple Interest.

using System;

namespace Assignment4 {
    
    // Class to calculate Simple Interest
    class SimpleIntrest {
        
        // Method to calculate and display simple interest
        public void Interest(double principal, double rate, double time) {
            double simpleIntrest = (principal * rate * time) / 100.0;
            Console.WriteLine("The Simple interest is " + simpleIntrest + " for principal " + principal + " rate of interest " + rate + " and time " + time);
        }
        
        // Main method 
        static void Main(String[] args) {
			// get input from the user 
            Console.Write("Enter the principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the rate of interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the time: ");
            double time = Convert.ToDouble(Console.ReadLine());
            
			//call Interest method
            SimpleIntrest SI = new SimpleIntrest();
            SI.Interest(principal, rate, time);
        }
    }
}
