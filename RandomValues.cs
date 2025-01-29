// Write a program that generates five 4 digit random values and then finds their average value, and their minimum and maximum value. 
// Use Math.Random(), Math.Min(), and Math.Max().


using System;

namespace Assignment4{

	class RandomValues {
		
		// Method to generate an array of 4-digit random numbers
		public int[] Generate4DigitRandomArray(int size) {
			Random random = new Random();
			int[] numbers = new int[size];
			for (int i = 0; i < size; i++) {
				numbers[i] = random.Next(1000, 10000); // Generates a random 4-digit number
			}
			return numbers;
		}

		// Method to find the average, minimum, and maximum value of an array
		public double[] FindAverageMinMax(int[] numbers) {
			double sum = 0;
			int min = numbers[0];
			int max = numbers[0];

			// Calculate the sum, min, and max
			foreach (int num in numbers) {
				sum += num;
				min = Math.Min(min, num); // Find the minimum
				max = Math.Max(max, num); // Find the maximum
			}

			double average = sum / numbers.Length;
			return new double[] { average, min, max };
		}

		static void Main() {
			RandomValues randomValues = new RandomValues();
			
			// Generate 5 random 4-digit numbers
			int[] randomNumbers = randomValues.Generate4DigitRandomArray(5);
			
			// Display the random numbers
			Console.WriteLine("Generated 4-digit random numbers:");
			foreach (int num in randomNumbers) {
				Console.WriteLine(num);
			}

			// Find and display the average, min, and max
			double[] result = randomValues.FindAverageMinMax(randomNumbers);
			Console.WriteLine("Average: "+result[0]);
			Console.WriteLine("Minimum Value: "+result[1]);
			Console.WriteLine("Maximum Value: "+result[2]);
		}
	}

}