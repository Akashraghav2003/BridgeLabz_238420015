// Create a program to find the bonus of 10 employees based on their years of service as well as 
// the total bonus amount the 10-year-old company Zara has to pay as a bonus, along with the old and new salary.



using System;

namespace Assignment4 {
    public class BonusCalculator {
        // Method to generate salary and years of service for 10 employees
        public static int[,] GenerateSalaryAndYears() {
            Random random = new Random();
            int[,] employeeData = new int[10, 2]; // [salary, years of service]

            for (int i = 0; i < 10; i++) {
                employeeData[i, 0] = random.Next(30000, 99999); // Generate a random 5-digit salary
                employeeData[i, 1] = random.Next(1, 15); // Random years of service between 1 and 15
            }

            return employeeData;
        }

        // Method to calculate new salary and bonus
        public static double[,] CalculateNewSalaryAndBonus(int[,] employeeData) {
            double[,] updatedData = new double[10, 2]; // [new salary, bonus amount]

            for (int i = 0; i < 10; i++) {
                double bonusPercentage;
                if (employeeData[i, 1] > 5) {
                    bonusPercentage = 0.05; // 5% bonus
                } else {
                    bonusPercentage = 0.02; // 2% bonus
                }

                double bonus = employeeData[i, 0] * bonusPercentage;
                double newSalary = employeeData[i, 0] + bonus;

                updatedData[i, 0] = newSalary;
                updatedData[i, 1] = bonus;
            }

            return updatedData;
        }

        // Method to calculate totals and display results
        public static void DisplayTotals(int[,] employeeData, double[,] updatedData) {
            double totalOldSalary = 0, totalNewSalary = 0, totalBonus = 0;

            Console.WriteLine("Employee\tOld Salary\tYears of Service\tBonus\tNew Salary");

            for (int i = 0; i < 10; i++) {
                totalOldSalary += employeeData[i, 0];
                totalNewSalary += updatedData[i, 0];
                totalBonus += updatedData[i, 1];

                Console.WriteLine(i + 1 + "\t\t" + employeeData[i, 0] + "\t\t" + employeeData[i, 1] + "\t\t" 
                                  + updatedData[i, 1] + "\t" + updatedData[i, 0]);
            }

            Console.WriteLine("Total\t\t" + totalOldSalary + "\t\t\t\t" + totalBonus + "\t" + totalNewSalary);
        }

        // Main method
        public static void Main() {
            // Step 1: Generate salary and years of service
            int[,] employeeData = GenerateSalaryAndYears();

            // Step 2: Calculate new salary and bonus
            double[,] updatedData = CalculateNewSalaryAndBonus(employeeData);

            // Step 3: Display totals in a tabular format
            DisplayTotals(employeeData, updatedData);
        }
    }
}
