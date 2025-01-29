// Write a program SpringSeason that takes two int values month and day from the command line 
// and prints “Its a Spring Season” otherwise prints “Not a Spring Season”. 

using System;

namespace Assignment4 {
    
    // Class to check if the given date falls in the Spring season
    class FindSpringSeason {
        
        // Method to check if the given date falls in the Spring season
        public bool SpringSeason(int day, int month) {
            bool isSpring = true;
            if (month == 3 && (day >= 20 && day <= 31)) {
                isSpring = true;
                return isSpring;
            } else if (month == 4 && (day >= 1 && day <= 30)) {
                isSpring = true;
                return isSpring;
            } else if (month == 5 && (day >= 1 && day <= 31)) {
                isSpring = true;
                return isSpring;
            } else if (month == 6 && (day >= 1 && day <= 20)) {
                isSpring = true;
                return isSpring;
            } else {
                isSpring = false;
                return isSpring;
            }
        }
        
        
        static void Main(String[] args) {
			//Take  input from user 
            Console.Write("Enter the Day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the Month: ");
            int months = Convert.ToInt32(Console.ReadLine());
            
			//call the SpringSeason method
            FindSpringSeason obj = new FindSpringSeason();
            bool isSpring = obj.SpringSeason(day, months);
			
            //check weather spring season or not
            if (isSpring) {
                Console.WriteLine("It's a Spring Season");
            } else {
                Console.WriteLine("Not a Spring Season");
            }
        }
    }
}
