//Create a program to check if a number is Armstrong or not.

using System;

class ArmstrongNumber{
	
	static void Main(string[] args){
		//taking the input from User
		Console.WriteLine("Enter a number: ");
		//convert into integer
		int number = Convert.ToInt32(Console.ReadLine());
		//make a copy of number
		int copyNumber=number;
		//initialize result with 0. 
		double result=0;
		
		//checking the number is not equal to 0 then make iteration
		while(number!=0)
		{
			int digit = number%10;
			//doing cube of each digit and add to the result
			result = result+ Math.Pow(digit,3);// adding the result value on each iteration
			
			number /= 10; //updation of while loop
		}
		
		//checking the result with copyNumber
		if(result==copyNumber){
			Console.WriteLine(copyNumber+" is  Armstrong Number");
		}else{
			Console.WriteLine(copyNumber+" is Not a Armstrong Number");
		}
	}
}