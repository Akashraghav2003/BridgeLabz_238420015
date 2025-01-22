//Create a variable named fee and take user input for fee.
//Create another variable discountPercent and take user input.
//Compute the discount and assign it to the discount variable.
//Compute and print the fee you have to pay by subtracting the discount from the fee.
//I/P => fee, discount Precent
//O/P => The discount amount is INR ___ and final discounted fee is INR ___

using System;

namespace Assignment{

	class FeeDiscountCalculator{
		
		static void Main(string[] args){
			
			// Taking the fee as  input from user
			Console.Write("Enter the student fee amount in INR: ");
			double fee = Convert.ToDouble(Console.ReadLine());

			// Taking the discountPercent as  input from user
			Console.Write("Enter the university discount percentage: ");
			double discountPercent = Convert.ToDouble(Console.ReadLine());

			// Compute discount amount
			double discount = (discountPercent / 100) * fee;

			// Compute final fee after discount
			double finalFee = fee - discount;

			// Display the results
			Console.WriteLine("The discount amount is INR "+discount+ " and the final discounted fee is INR "+finalFee);
		}
	}
}
