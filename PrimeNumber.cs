//Write a Program to check if the given number is a prime number or not

using System;

namespace Assignment3{

	class PrimeNumber{
		
		static void Main(){
			
			//take input from user as datatype int
			Console.Write("Enter a number: ");
			int number = Convert.ToInt32(Console.ReadLine());

			//check number isnatural or not 
			if (number <= 1){
				
				Console.WriteLine("Number should be grater than zero");
			}else{
				
				//isPrime variable to store the value that number is prime or not
				bool isPrime = true;

				for (int i = 2; i <=n; i++{
					if (number % i == 0){
						isPrime = false;
						break; // Exit loop if the number is divisible
					}
				}
				
				//if condition to print final result
				if (isPrime){
					Console.WriteLine($"{number} is a prime number.");
				}else{
					Console.WriteLine($"{number} is not a prime number.");
				}
			}
		}
	}

}