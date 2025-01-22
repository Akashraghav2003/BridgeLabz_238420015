//The University is charging the student a fee of INR 125000 for the course. 
//The University is willing to offer a discount of 10%. 
//Write a program to find the discounted amount and discounted price the student will pay for the course.

using System;

namespace Assignment{
	class CourseFeeCalculator{
		static void Main(String [] args){
			int fee = 125000;
			double discountPer = 10;
			double discountAmount = fee/discountPer;
			double finalFee = fee - discountAmount;
			
			Console.WriteLine("The Discount amount is INR "+discountAmount+" and final discount fee is INR "+finalFee);
			
		}
	}
}