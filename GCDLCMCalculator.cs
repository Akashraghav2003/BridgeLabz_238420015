

// GCD and LCM Calculator:/6
// Create a program that calculates the Greatest Common Divisor (GCD) and Least Common
// Multiple (LCM) of two numbers using functions.
// ● Use separate functions for GCD and LCM calculations, showcasing how modular code
// works.
using System;

class GCDLCMCalculator{
	

	// Method to take two integer inputs from the user
	public static int[] Input(){
		Console.WriteLine("Enter the first number: ");
		int num1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the second number: ");
		int num2 = Convert.ToInt32(Console.ReadLine());

		return new int[]{num1, num2};
	}

	// Method to calculate GCD (Greatest Common Divisor)
	public int GCD(){
		Console.WriteLine("Enter the numbers for GCD: ");
		int[] input = Input();
		int result = 1;

		// Check for common divisors
		for(int i = 2; i <= input[0]; i++){
			if(input[0] % i == 0 && input[1] % i == 0) 
				result = i;
		}
		return result;
	}

	public int LCM(){
    Console.WriteLine("Enter the numbers for LCM: ");
    int[] input = Input();
    int a = input[0];
    int b = input[1];
    
    int max = (a > b) ? a : b; // Start from the maximum of both numbers

    while (true){
        if (max % a == 0 && max % b == 0){
            return max; 
        }
        max++; 
    }
}


	// Display the GCD and LCM results
	public void Display(){
		Console.WriteLine("The Greatest Common Divisor (GCD) is: " + GCD());
		Console.WriteLine("The Least Common Multiple (LCM) is: " + LCM());
	}

	public static void Main(String[] args){
		
		GCDLCMCalculator obj = new GCDLCMCalculator(); // Create a class instance

		obj.Display();
	}
}
