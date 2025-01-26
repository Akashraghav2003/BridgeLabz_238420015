//Write a program to check whether a number is positive, negative, or zero. 


using System;

class NumberChecking{

	static void Main(string [] args){
	
		// display the message and take input from user
		Console.WriteLine("Enter a Number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		
		//Check weather number is positive negative and zero
		if(number>0){
			Console.WriteLine("The number is Positive.");
		}
		else if(number<0){
			Console.WriteLine("The number is Negative");
		}else{
			Console.WriteLine("The number is Zero");	
		}
		
	}
}