//Write a program to find the sum of numbers until the user enters 0

using System;

namespace Assignment{
	
	 class SumUntilPressZero{
		 
		  static void Main(){
			  
			  //Inalitize the number in which we take input
			 double number = 1;
			 
			 //Inalitize the total in which we get sum
			 double total =0;
			 
			  while(number != 0){//check that number is 0 or not and iterate the loop
				  //take input as the number
				  Console.WriteLine("Enter the number: ");
				  number = Convert.ToDouble(Console.ReadLine());
				  total += number;
			  }
			  //Display final result
			  Console.WriteLine("Sum of given inputs : "+ total);
			  
		  }
	 }
}