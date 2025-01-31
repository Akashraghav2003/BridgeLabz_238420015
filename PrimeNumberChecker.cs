// 3. Prime Number Checker:
// Create a program that checks whether a given number is a prime number.
// ● The program should use a separate function to perform the prime check and return
// the result.
using System;

class PrimeNumberChecker{
	
	// Method to take an integer input from the user
	public static int Input(){
		Console.WriteLine("Enter the number: ");
		return Convert.ToInt32(Console.ReadLine());
	}

	// Method to check if the given number is prime
	public static bool Prime(){
		int input = Input();
		bool isPrime = true;

		if(input == 1){
			isPrime = false;
		} else if(input == 2){
			isPrime = true;
		} else if(input % 2 == 0){
			isPrime = false;
		} else {
			// Check divisibility from 2 to input/2
			for(int i = 2; i < (input / 2 + 1); i++){
				if(input % i == 0){
					isPrime = false;
					break;
				}
			}
		}
		return isPrime;
	}

	// Display the result
	static void Display(){
		if(Prime()){
			Console.WriteLine("Given number is a prime number.");
		} else {
			Console.WriteLine("Given number is not a prime number.");
		}
	}

	public static void Main(){
		Display();
	}
}
