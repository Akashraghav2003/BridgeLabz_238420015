//Harshad Number.
using System;

class HarshadNumber{
	
	static void Main(string[] args)
	{
		Console.WriteLine("Enter a number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		int copyNumber=number;
		double sumOfDigits=0;
		while(number!=0)
		{
			int digit = number%10;
			//doing cube of each digit and add to the result
			sumOfDigits = sumOfDigits+ digit;// adding the result value on each iteration
			
			number /= 10; //updation of while loop
		}
		
		
		if(copyNumber%sumOfDigits==0)
		{
			Console.WriteLine(copyNumber+" is  Harshed Number");
		}
		else
		{
			Console.WriteLine(copyNumber+" is Not a Harshed Number");
		}
	}
}