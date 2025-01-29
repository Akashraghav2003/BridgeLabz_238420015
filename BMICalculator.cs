// An organization took up the exercise to find the Body Mass Index (BMI) of all the persons in the team of 10 members. 
// For this create a program to find the BMI and display the height, weight, BMI and status of each individual

using System;

namespace Assignment4{
	
    class BMICalculator{
		
        // Method to calculate BMI and determine BMI status
        static void CalculateBMI(double[,] data, string[] bmiStatus){
			
            for (int i = 0; i < 10; i++){
				
                // Convert height from cm to meters
                double heightInMeters = data[i, 1] / 100;

                // Calculate BMI using the formula
                data[i, 2] = data[i, 0] / (heightInMeters * heightInMeters);

                // Determine BMI status
                if (data[i, 2] < 18.5){
					
                    bmiStatus[i] = "Underweight";
                }else if (data[i, 2] >= 18.5 && data[i, 2] < 24.9){
                    bmiStatus[i] = "Normal weight";
                }else if (data[i, 2] >= 25 && data[i, 2] < 29.9){
                    bmiStatus[i] = "Overweight";
                }else{
                    bmiStatus[i] = "Obese";
                }
            }
        }

        // Main method
        static void Main(){
            // Create a 2D array to store weight, height, and BMI for 10 members
            double[,] data = new double[10, 3]; // [rows: individuals, columns: weight, height, BMI]
            string[] bmiStatus = new string[10]; // Array to store BMI status

            // Input weight and height for each member
            Console.WriteLine("Enter the weight (kg) and height (cm) for 10 members:");

            for (int i = 0; i < 10; i++){
                Console.Write("Person " + (i + 1) + " - Weight (kg): ");
                data[i, 0] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Person " + (i + 1) + " - Height (cm): ");
                data[i, 1] = Convert.ToDouble(Console.ReadLine());
            }

            // Calculate BMI and determine BMI status
            CalculateBMI(data, bmiStatus);

            // Display results
            Console.WriteLine("Results:");
            Console.WriteLine("Person   Weight (kg)   Height (cm)   BMI         Status");
            for (int i = 0; i < 10; i++){
                string person = (i + 1).ToString();
                string weight = data[i, 0].ToString("0.00");
                string height = data[i, 1].ToString("0.00");
                string bmi = data[i, 2].ToString("0.00");
                string status = bmiStatus[i];

                Console.WriteLine(person.PadRight(8) + weight.PadRight(13) + height.PadRight(13) + bmi.PadRight(11) + status);
            }
        }
    }
}
