//abundant number 
using System;

class AbundantNumber {
	
	static void Main(string[] args)
	{
		//Taking input 
		Console.WriteLine("Enter a number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		int sum=0;
		for(int i=1;i<number;i++)//using loop for findind divisor
		{
			if(number%i==0)
			{
				sum+=i;//sum the divisors
			}
		}
		if(number<sum)//check the codition
		{
			Console.WriteLine("Number is Abundant");
		}
		else
		{
			Console.WriteLine("Number is Not Abundant");
			
		}
		
	}
}