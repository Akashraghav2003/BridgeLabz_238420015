//Create a program to print odd and even numbers between 1 to the number entered by the user.

using System;

namespace Assignment3{
	
	class CheckEvenOdd{
		
		static void Main(){
			
			// Taking input from user as a number
			Console.WriteLine("Enter the number ");
			int number = Convert.ToInt32(Console.ReadLine());
			
			if (number <1){          // to check number natural or not
				Console.WriteLine("Enter the natural number. Number should be grater than 0.");
			}else{
				for (int i = 1;i<=number;i++){  //iterate the loop for even or odd number
					
					//check the i is even or odd
					if(i % 2 ==0){
						
						//Display the result.
						Console.WriteLine(i+"is an Even number");
					}else{
						Console.WriteLine(i+" is an odd number");
					}
				}
			}
		}
	}
}