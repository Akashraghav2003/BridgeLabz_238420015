//Create a program to find the bonus of 10 employees based on their years of service and the total bonus amount the company Zara has to pay, along with the old and new salary.

using System;

namespace ArrayLevel2{
	
	class BonusCalculator{
		
		static void Main(String [] args){
			//gives no of employee
			int totalEmployee = 10;
			//inatialize array for store salary and year of working
			double [] salaries  = new double[totalEmployee];
			double [] yearWorking  = new double[totalEmployee];
				
			//inatialize array for store newsalary and bonus of working
			double [] bonus  = new double[totalEmployee];
			double [] newSalaries  = new double[totalEmployee];
			
			double totalBonus = 0;
			double totalOldSalary = 0;
			double totalNewSalary = 0;
			
			for (int i=0; i<totalEmployee;i++){
				
				 //input salaries
				 while (true){
					 
					Console.Write("Enter salary: ");
					//check the salary is double or not and store in salary variable
					if (double.TryParse(Console.ReadLine(), out double salary) && salary > 0)
					{
						salaries[i] = salary;
						totalOldSalary += salary;
						break;
					}
					Console.WriteLine("Invalid salary. Please enter a positive number.");
				}

            // Input years of service
				while (true)
				{
					Console.Write("Enter years of service: ");
					//check the year is double or not and store in year variable
					if (double.TryParse(Console.ReadLine(), out double years) && years >= 0)
					{
						yearWorking[i] = years;
						break;
					}
					Console.WriteLine("Invalid years of service. Please enter a non-negative number.");
				}
			}
			
				
			 // Calculate bonus and new salary
			for (int i = 0; i < totalEmployee; i++)
			{
				if (yearWorking[i] > 5)
				{
					bonus[i] = salaries[i] * 0.05;
				}
				else
				{
					bonus[i] = salaries[i] * 0.02;
				}

				newSalaries[i] = salaries[i] + bonus[i];
				totalBonus += bonus[i];
				totalNewSalary += newSalaries[i];
			}

			// Display final  results
			Console.WriteLine("\nEmployee Details:");
			for (int i = 0; i < totalEmployee; i++)
			{
				Console.WriteLine($"Employee {i + 1}: Old Salary = {salaries[i]:C}, Years of Service = {yearWorking[i]}, Bonus = {bonus[i]:C}, New Salary = {newSalaries[i]:C}");
			}

			Console.WriteLine($"\nTotal Bonus Payout: {totalBonus:C}");
			Console.WriteLine($"Total Old Salary: {totalOldSalary:C}");
			Console.WriteLine($"Total New Salary: {totalNewSalary:C}");
		}
	}
}