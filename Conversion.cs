using System;

class Conversion{
	
	static void Main (String [] args){
		
		Console.WriteLine("Write the temp in Celsius");
		int temp = Convert.ToInt32(Console.ReadLine());
		
		double fehr =(temp*9/5.0)+32; 
		
		Console.WriteLine("Temperature in fahrenheit: "+ fehr);
	}
}