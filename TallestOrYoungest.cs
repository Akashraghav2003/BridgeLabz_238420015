// Create a program to find the youngest friends among 3 Amar, Akbar and Anthony 
// based on their ages and tallest among the friends based on their heights and display it


using System;

namespace Assignment4 {

    class TallestOrYoungest {

        // Method to find the youngest friend's index
        public static int FindYoungest(int[] ages) {
            int youngestIndex = 0;
            for (int i = 1; i < ages.Length; i++) {
                if (ages[i] < ages[youngestIndex]) {
                    youngestIndex = i;
                }
            }
            return youngestIndex;
        }

        // Method to find the tallest friend's index
        public static int FindTallest(double[] heights) {
            int tallestIndex = 0;
            for (int i = 1; i < heights.Length; i++) {
                if (heights[i] > heights[tallestIndex]) {
                    tallestIndex = i;
                }
            }
            return tallestIndex;
        }

        static void Main(string[] args) {
            string[] friends = { "Amar", "Akbar", "Anthony" };
            int[] ages = new int[3];
            double[] heights = new double[3];

            // Input ages and heights for the three friends
            for (int i = 0; i < friends.Length; i++) {
                Console.Write("Enter the age of " + friends[i] + ": ");
                ages[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the height (in meters) of " + friends[i] + ": ");
                heights[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Find the youngest and tallest friends
            int youngestIndex = FindYoungest(ages);
            int tallestIndex = FindTallest(heights);

            // Display the results
            Console.WriteLine("\nThe youngest friend is " + friends[youngestIndex] + " with age " + ages[youngestIndex] + ".");
            Console.WriteLine("The tallest friend is " + friends[tallestIndex] + " with height " + heights[tallestIndex] + " meters.");
        }
    }
}

