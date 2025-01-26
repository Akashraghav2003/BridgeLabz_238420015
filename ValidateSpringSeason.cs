//Write a program SpringSeason that takes two int values month and day from the command line and 
//prints “Its a Spring Season” otherwise prints “Not a Spring Season”. 

using System;

class ValidateSpringSeason{
	
    static void Main(string[] args){
		
        
        
            //convert args into month and day
            int month = Convert.ToInt32(args[0]);
            int day = Convert.ToInt32(args[1]);

            // variable to validate spring season
            bool isSpring = false;

			//check it is a spring season
            if (month == 3 && (day >= 20 && day <= 31)){
                isSpring = true;
            }
            else if (month == 4 && (day >= 1 && day <= 30)){
                isSpring = true;
            }
            else if (month == 5 && (day >= 1 && day <= 31)){
                isSpring = true;
            }
            else if (month == 6 && (day >= 1 && day <= 20)){
                isSpring = true;
            }

            // Display the result
            if (isSpring){
                Console.WriteLine("It's a Spring Season");
            }else{
                Console.WriteLine("Not a Spring Season");
            }
    }

}