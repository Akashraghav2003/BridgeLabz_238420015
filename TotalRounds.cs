// An athlete runs in a triangular park with sides provided as input by the user in meters. 
// If the athlete wants to complete a 5 km run, 
// then how many rounds must the athlete complete

using System;

namespace Assignment4 {
    
    // Class to calculate total rounds completed by a person
    class TotalRounds {
        
        // Method to calculate and return the number of rounds
        public double Rounds(double length, double width, double height) {
            double distance = 5.0;
            double perimeter = length + width + height;
            double numOfRounds = distance / perimeter;
            return numOfRounds;
        }
        
        static void Main(String[] args) {
			
			 // get user inputs 

            Console.Write("Enter the Length of triangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the width of triangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the height of triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());
            
			//call the Rounds method
            TotalRounds tr = new TotalRounds();
            double round = tr.Rounds(length, width, height);
            Console.WriteLine("Total Rounds held by person: " + round);
        }
    }
}
