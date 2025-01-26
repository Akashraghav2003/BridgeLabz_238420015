//Write a program to find the sum of n natural numbers using while loop.
//compare the result with the formulae n*(n+1)/2 and show the result from both computations was correct.

using System;

namespace Assignment{
	
	 class SumOfNaturalNo{
		 
		  static void Main(){
			  //initalize the variable to store final result
			  int sum = 0;
			  
			// take input as the number  whose sum we want
			  Console.WriteLine("Enter the number: ");
			  int number = Convert.ToInt32(Console.ReadLine());
			  
			  //result variable is used for find Sum of number
			  int result = (number*(number+1))/2;
			  
			  if(number >0){ // check the number is natural or not
				  
				  while(number>0){
					  
					  sum += number;
					  number--;
				  }
				  
			  }else{
				  
				  Console.WriteLine("Given number is not natural number. ");
			  }
			  if(result == sum){// compare formula or loop result 
				  
				  //Display the final result
				  Console.WriteLine("Sum of given natural number is "+sum);
			  }
			    
		  }
	 }
}