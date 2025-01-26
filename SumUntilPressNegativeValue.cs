//Write a program to find the sum of numbers until the user enters 0 or negative value.

using System;

namespace Assignment{
	
	 class SumUntilPressNegativeValue{
		 
		  static void Main(){
			  
			  //Inalitize the number in which we take input
			 double number = 1;
			 
			 //Inalitize the total in which we get sum
			 double sum =0;
			 
			 //check that number is 0 or not and iterate the loop
			  while(number > 0){
				  
				  //take input as the number 
				  Console.WriteLine("Enter the number: ");
				  number = Convert.ToDouble(Console.ReadLine());
				  sum += number;
				  
				  // check that number is negative or Zero
				  if(number <= 0 ){
					  break;
				  }
			  }
			  //Final result
			  Console.WriteLine("Sum of given inputs : "+ sum);
			  
		  }
	 }
}