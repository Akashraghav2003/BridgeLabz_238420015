//Create a program to find the bonus of employees based on their years of service.
//if year of service is more than 5 then give 5% of bonus

using System;

namespace Assignment{
	
	class BonusCalculator{
		
		static void Main (){
			//take input for salary and year of service
			Console.WriteLine("Enter the salary");
			int salary = Convert.ToInt32(Console.ReadLine());//storing the salary
			
			Console.WriteLine("Enter the year of service");
			//Storing the year of workingl;.
			int experiance = Convert.ToInt32(Console.ReadLine());
			
			if(experiance>5){ //Check year of working is greater than 5 or not
				double bonusPercentage = 5; //bonus percentage given to Employee 
				
				double bonus = (salary*bonusPercentage)/100;   //total amount of bonuss
				
				//dispaly the result
				Console.WriteLine("Bonus for employee is: "+ bonus);
			}else{
				//display the result if working year is less than 5.
				Console.WriteLine("Service Year is less than 5.");
			}
		}
	}
}