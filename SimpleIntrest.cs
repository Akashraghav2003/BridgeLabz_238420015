using System;

class SimpleIntrest{
	static void Main(String [] args){
		Console.WriteLine("Enter the principal amount: ");
		int principal = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the rate of intrest: ");
		double rate = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter the time in years: ");
		double time = Convert.ToDouble(Console.ReadLine());
		
		Double intrest = (principal*rate*time)/100.0;
		
		Console.WriteLine("intrest on this amount in "+time+" years is: "+ intrest);
	}
}