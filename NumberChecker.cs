// Extend or Create a NumberChecker utility class and perform the following task.
// Call from the main() method the different methods and display results. Make sure all are static methods

using System;

namespace Assignment4{
	
	class NumberChecker{
		
		// Method to count the number of digits
		public static int CountDigit(int number){
			int count = 0;
			while(number > 0){
				number /= 10;
				count++;
			}
			return count;
		}
		
		// Method to get digits as an array
		public static int [] DigitArray(int number, int count){
			int [] digit = new  int [count];
			int index = count-1;
			while(number > 0){
				digit[index] = number % 10;
				number /= 10;
				index--;
			}
			return digit;
		}
		
		// Check if the number is a Duck number
		public static bool DuckNumber(int [] digit){
			bool isDuck = true;
			int n = digit.Length;
			if(digit[0] != 0){
				for(int i =1; i<n;i++ ){
					if(digit[i] != 0){
						isDuck = true;
						break;
					}else{
						isDuck = false;
					}
				}
			}else{
				isDuck = false;
			}
			return isDuck;
		}
		
		// Check if the number is an Armstrong number
		public static bool ArmstrongNumber(int [] digit,int number){
			bool isArmstrong = true;
			double sum = 0;
			int n = digit.Length;
			int i = 0;
			while(i<n){
				sum += Math.Pow(digit[i],n);
				i++;
			}
			isArmstrong = (sum == number) ? true : false;
			return isArmstrong;
		}
		
		// Find the largest and second largest digits
		public static void LargestOrSecondLargest(int[] digit, out int large, out int secLarge){
			large = Int32.MinValue;
			secLarge = Int32.MinValue;
			for (int i = 0; i < digit.Length; i++){
				if (digit[i] > large){
					secLarge = large;
					large = digit[i];
				}
				else if (digit[i] > secLarge && digit[i] != large)
				{
					secLarge = digit[i];
				}
			}
		}

		// Find the smallest and second smallest digits
		public static void SmallestOrSecondSmallest(int[] digit, out int min, out int secMin){
			min = Int32.MaxValue;
			secMin = Int32.MaxValue;
			for (int i = 0; i < digit.Length; i++){
				if (digit[i] < min){
					secMin = min;
					min = digit[i];
				}
				else if (digit[i] < secMin && digit[i] != min){
					secMin = digit[i];
				}
			}
	    }

		// Main method
		public static void Main(){
			
			// Get user input
			Console.WriteLine("Enter the number: ");
			int number = Convert.ToInt32(Console.ReadLine());
			
			int count = CountDigit(number);
			int [] digit = DigitArray(number,count);
			
			bool isDuck = DuckNumber(digit);
			bool isArmstrong = ArmstrongNumber(digit, number);
			
			int max, secMax;
			int min, secMin;
			
			LargestOrSecondLargest(digit, out max, out secMax);
			SmallestOrSecondSmallest(digit, out min, out secMin);
			
			// Display results
			Console.WriteLine("Total digit in the number: "+ count);
			for(int i=0; i<count; i++){
				Console.WriteLine (i+" digit of number is: "+ digit[i]);
			}
			
			Console.WriteLine(isDuck ? "This is a Duck number" : "This is not a Duck number");
			Console.WriteLine(isArmstrong ? "This is an Armstrong number" : "This is not an Armstrong number");
			Console.WriteLine($"Largest: {max}, Second largest: {secMax}");
			Console.WriteLine($"Smallest: {min}, Second smallest: {secMin}");
		}
	}
}
