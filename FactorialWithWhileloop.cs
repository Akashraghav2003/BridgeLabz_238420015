//Write a Program to find the factorial of an integer entered by the user using while loop.

using System;

namespace Assignment3{
	
	class FactorialWithWhileloop{
		
		static void Main(){
			//Initialize the factorial variable
			int factorial = 1;
			
			//take input from user 
			Console.WriteLine("Enter the number to find factorial ");
			
			//value store in number variable
			int number = Convert.ToInt32(Console.ReadLine());
			int orgnumber = number; // value of number store in orgnumber to restore the value
			
			if (number <0){ //to check the no is positive or not
				Console.WriteLine("Enter the positive number.");
			}
			else if(number == 0){
				// 0 has the factorial 1
				Console.WriteLine("Factorial of 0 is 1.");
			}
			else{
				//iterate the for find factorial
				while(number >= 1){
					factorial *= number;
					number--;
				}
				//display the result
			Console.WriteLine($"Factorial of {orgnumber} is {factorial}.");
			}
		}
	}
}