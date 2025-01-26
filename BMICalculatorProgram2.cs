// Rewrite the above program using multi-dimensional array to store height, weight, and BMI in 2D array for all the persons
// Hint => 
// Take input for a number of persons
// Create a multi-dimensional array to store weight, height and BMI. Also create an to store the weight status of the persons
       // double[][] personData = new double[number][3];
       // String[] weightStatus = new String[number];
// Take input for weight and height of the persons and for negative values, ask the user to enter positive values
// Calculate BMI of all the persons and store them in the personData array and also find the weight status and put them in the weightStatus array
// Display the height, weight, BMI and status of each person


using System;

namespace  ArrayLevel2
{
    class BMICalculatorProgram2
    {
        static void Main()
        {
            // Take input for the number of persons
            Console.Write("Enter the number of persons: ");
            int number = int.Parse(Console.ReadLine());

            // Multi-dimensional array to store height, weight, and BMI
            double[,] personData = new double[number, 3];
            string[] weightStatus = new string[number];

            // Input weight and height for each person
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Person " + (i + 1) + ":");

                // Input height and validate it
                Console.Write("Enter height (in meters): ");
                personData[i, 0] = double.Parse(Console.ReadLine());
                while (personData[i, 0] <= 0)
                {
                    Console.WriteLine("Height must be a positive value. Please try again.");
                    Console.Write("Enter height (in meters): ");
                    personData[i, 0] = double.Parse(Console.ReadLine());
                }

                // Input weight and validate it
                Console.Write("Enter weight (in kilograms): ");
                personData[i, 1] = double.Parse(Console.ReadLine());
                while (personData[i, 1] <= 0)
                {
                    Console.WriteLine("Weight must be a positive value. Please try again.");
                    Console.Write("Enter weight (in kilograms): ");
                    personData[i, 1] = double.Parse(Console.ReadLine());
                }

                // Calculate BMI and store it
                personData[i, 2] = personData[i, 1] / (personData[i, 0] * personData[i, 0]);

                // Determine weight status based on BMI
                if (personData[i, 2] < 18.5)
                {
                    weightStatus[i] = "Underweight";
                }
                else if (personData[i, 2] >= 18.5 && personData[i, 2] < 24.9)
                {
                    weightStatus[i] = "Normal weight";
                }
                else if (personData[i, 2] >= 25 && personData[i, 2] < 29.9)
                {
                    weightStatus[i] = "Overweight";
                }
                else
                {
                    weightStatus[i] = "Obese";
                }
            }

            // Display the results
            Console.WriteLine("\nResults:");
            Console.WriteLine("Person\tHeight (m)\tWeight (kg)\tBMI\t\tStatus");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine((i + 1) + "\t" + personData[i, 0].ToString("F2") + "\t\t" + personData[i, 1].ToString("F2") + "\t\t" + personData[i, 2].ToString("F2") + "\t" + weightStatus[i]);
            }
        }
    }
}
