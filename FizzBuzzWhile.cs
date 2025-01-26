//FizzBuzz using while loop


using System;

class FizzBuzzWhile{

    static void Main(){
		
		//take input from user as datatype int
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

		//if statement check that number is positive or not
        if (number > 0){
			
			//initalize i for iterator
			int i = 0;
			
			//loop used to draw the pattern
            while (i <= number){
				//if to check number is divide by three or five
                if (i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                }else if (i % 3 == 0){
                    Console.WriteLine("Fizz");
                }else if (i % 5 == 0){
                    Console.WriteLine("Buzz");
                }else{
                    Console.WriteLine(i);
                }
				i++;
            }
        }else{
			//display the result 
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}