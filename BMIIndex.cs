//Create a program to find the BMI of a person
//Hint => 
//Take user input in double for the weight (in kg) of the person and height (in cm) for the person and store it in the corresponding variable.
//Use the formula BMI = weight / (height * height). Note unit is kg/m^2. For this convert cm to meter
//Use the table to determine the weight status of the person




using System;

class BMIIndex{
	
    static void Main(){
		
        Console.Write("Enter weight (in kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height (in cm): ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        // Convert height from cm to meters
        double heightM = heightCm / 100;

        // Calculate BMI
        double bmi = weight / (heightM * heightM);

        // Display BMI
        Console.WriteLine("Your BMI is " + bmi);

        // Determine weight status based on BMI
        if (bmi < 18.5){
            Console.WriteLine("Weight Status: Underweight");
        }
        else if (bmi >= 18.5 && bmi < 24.9){
            Console.WriteLine("Weight Status: Normal weight");
        }
        else if (bmi >= 25 && bmi < 29.9){
            Console.WriteLine("Weight Status: Overweight");
        }
        else{
            Console.WriteLine("Weight Status: Obese");
        }
    }
}
