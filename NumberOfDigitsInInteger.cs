//Number of Digits in an integer
using System;

class NumberOfDigitsInInteger{
	
	static void Main(string[] args)
	{
		Console.WriteLine("Enter an Integer: ");
		int number = Convert.ToInt32(Console.ReadLine());
		//int copyNumber=number;
		double numOfDigits=0;
		
		while(number!=0)
		{
			int digit = number%10;//work on each and every digits
			numOfDigits++;//count number of digits
			number /= 10; //updation of while loop
			
		}
		Console.WriteLine("Total number digits in an integer: "+numOfDigits);
	}
}