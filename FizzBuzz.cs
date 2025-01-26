//program FizzBuzz, take a number as user input, and if it is a positive integer loop from 0 to the number and print the number, but for multiples of 3 print "Fizz" instead of the number, for multiples of 5 print "Buzz", and for multiples of both print "FizzBuzz".



using System;

class FizzBuzz{

    static void Main(){
		
		//take input from user as datatype int
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

		//if statement check that number is positive or not
        if (number > 0){
			
			//loop used to draw the pattern
            for (int i = 0; i <= number; i++){
				
				//if to check number is divide by three or five 
                if (i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                }
				//to check number is divide by three
				else if (i % 3 == 0){
                    Console.WriteLine("Fizz");
                }
				//to check number is divide by three
				else if (i % 5 == 0){
                    Console.WriteLine("Buzz");
                }
				else{
                    Console.WriteLine(i);
                }
            }
        }else{
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}
