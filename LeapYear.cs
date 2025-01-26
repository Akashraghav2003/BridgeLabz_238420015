//Write a LeapYear program that takes a year as input and outputs the Year is a Leap Year or not a Leap Year. 

using System;

namespace Assignment{
	
    class LeapYear{
		
        static void Main(){
			
			//take the year from user
            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine()); // Changed to Convert.ToInt32 for correct type
			
			
			// Check wheather given year is grater than 1581 or not
            if (year >= 1582){
				
				//check year is leap year or not
                if (year % 4 == 0){
					
					//check year is divide by 100 or not 
                    if (year % 100 == 0){
						//for leap yaer if year divide by 100 it should be divide by 400
                        if (year % 400 == 0){
							
							//Display result
                            Console.WriteLine("Given year is a leap year");
                        }else{
							//condition not satisfied
                            Console.WriteLine("Given year is not a leap year");
                        }
                    }else{
                        Console.WriteLine("Given year is a leap year");
                    }
                }else{
                    Console.WriteLine("Given year is not a leap year");
                }
            }else{
                Console.WriteLine("Year should be >= 1582");
            }
        }
    }
}
