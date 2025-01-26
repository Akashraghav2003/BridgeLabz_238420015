//Write a Program to find the factorial of an integer entered by the user using for loop.


using System;

namespace Assignment3{
	
	class FactorialWithForloop{
		
		static void Main(){
			//Initialize the factorial variable
			int factorial = 1;
			
			//take input from user
			Console.WriteLine("Enter the number to find factorial ");
			//value store in number variable
			int number = Convert.ToInt32(Console.ReadLine());
			
			if (number <0){//to check the no is positive or not
				Console.WriteLine("Enter the positive number.");
			}
			else if(number == 0){
				// 0 has the factorial 1
				Console.WriteLine("Factorial of 0 is 1.");
			}
			else{
				//to iterate the for find factorial
			for(int i = number; i>0;i-- ){
				factorial *= i;
			}
			//display the result
			Console.WriteLine($"Factorial of {number} is {factorial}.");
			}
		}
	}
}