// Create a program to find the shortest, tallest, and mean height of players present in a football team.
// Hint => 
// a.The formula to calculate the mean is: mean = sum of all elements/number of elements
// b.Create an int array named heights of size 11 and get 3 digits random height in cms for each player in the range 150 cms to 250 cms
// c.Write the method to Find the sum of all the elements present in the array.
// d.Write the method to find the mean height of the players on the football team
// e.Write the method to find the shortest height of the players on the football team 
// f.Write the method to find the tallest height of the players on the football team
// g.Finally display the results


using System;

namespace Assignment4{
	
	class TallestOrSmallestOrMeanHeight{
		
		// Method to calculate the sum of heights
		public static int Sum (int [] height){
			int n = height.Length; // Get the length of the array
			int sumOfHeight =0; // Initialize sum variable
			for (int i =0; i<n; i++){
				sumOfHeight += height[i]; // Add each height to the sum
			}
			return sumOfHeight; // Return the total sum
		}
		
		// Method to calculate the mean height
		public static double MeanHeight (int [] height){
			double n = height.Length; // Get the length of the array as double
			int sum = Sum(height); // Get the sum of all heights
			double meanHeight = sum/n; // Calculate the mean (average) height
			return meanHeight; // Return the mean height
		}
		
		// Method to find the shortest height
		public static int ShortestHeight(int [] height){
			double n = height.Length; // Get the length of the array
			int min = height[0]; // Assume the first height as the smallest
			for(int i = 1; i<n; i++){
				if(height[i] < min){ // If current height is smaller, update min
					min = height[i];
				}
			}
			return min; // Return the smallest height
		}
		
		// Method to find the tallest height
		public static int TallestHeight(int [] height){
			double n = height.Length; // Get the length of the array
			int max = height[0]; // Assume the first height as the tallest
			for(int i = 1; i<n; i++){
				if(height[i] > max){ // If current height is larger, update max
					max = height[i];
				}
			}
			return max; // Return the tallest height
		}
		
		// Main method to execute the program
		static void Main(){
			
			int [] height = new int[11]; // Array to store heights of 11 players
			int  n = height.Length; // Get the length of the array (11 players)
			
			Random random =new Random(); // Create a random number generator
			for(int i= 0;i<n;i++){
				height[i] = random.Next(100,1000); // Assign a random height between 100 and 1000
			}
			
			// Calculate sum, mean, shortest and tallest height
			int sum = Sum(height);
			double meanHeight = MeanHeight(height);
			int shortestHeight = ShortestHeight(height);
			int tallestHeight = TallestHeight(height);
			
			// Display the results
			Console.WriteLine("The sum of player height is: "+ sum);
			Console.WriteLine("The mean height of player is: "+ meanHeight);
			Console.WriteLine("The tallest height of player is: "+ tallestHeight);
			Console.WriteLine("The shortest height of player is: "+ shortestHeight);
		}
	}
}
