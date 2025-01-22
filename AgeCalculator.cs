using System;

namespace Assignment{
	class AgeCalculator{
		
		static void Main (String [] args){
			int currentYear = 2024; //declear present year
			int birthYear = 2000; //declear birth year
			int currentAge = currentYear - birthYear; //current age of harry
			
			//display the current age of harry
			Console.WriteLine("Harry age in 2024 is "+currentAge);
			
		}
	}
}


