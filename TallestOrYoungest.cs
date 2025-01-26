//Create a program to find the youngest friends among 3 Amar, Akbar, and Anthony based on their ages and the tallest among the friends based on their heights
//Hint => 
//Take user input for the age and height of the 3 friends and store it in a variable
//Find the smallest of the 3 ages to find the youngest friend and display it
//Find the largest of the 3 heights to find the tallest friend and display it

using System;

namespace Assignment3{
	
	class TallestOrYoungest{
		
		static void Main(){
			// Input ages
        Console.Write("Enter Amar's age: ");
        int amarAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Akbar's age: ");
        int akbarAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Anthony's age: ");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());

        // Input heights
        Console.Write("Enter Amar's height (in cm): ");
        double amarHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Akbar's height (in cm): ");
        double akbarHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Anthony's height (in cm): ");
        double anthonyHeight = Convert.ToDouble(Console.ReadLine());
		
		//condition for compare on age
		if (amarAge < akbarAge){
			if(amarAge < anthonyAge){
				Console.WriteLine("Amar is youngest among all.");
			}
			else{
				Console.WriteLine("Anthony is youngest among all.");
			}
			
		}else{
			if(akbarAge < anthonyAge ){
				Console.WriteLine("Akbar is youngest among all.");
			}else{
				Console.WriteLine("Anthony is youngest among all.");
			}
		}
		
		//condition for compare on height
		if (amarHeight > akbarHeight){
			if(amarHeight > anthonyHeight){
				Console.WriteLine("Amar is tallest among all.");
			}
			else{
				Console.WriteLine("Anthony is tallest among all.");
			}
			
		}else{
			if(akbarHeight > anthonyHeight ){
				Console.WriteLine("Akbar is tallest among all.");
			}else{
				Console.WriteLine("Anthony is tallest among all.");
			}
		}

			
		}
	}
}
