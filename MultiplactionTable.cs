//Create a program to find the multiplication table of a number entered by the user from 6 to 9.

using System;

namespace Assignment3{
	
	class MultiplactionTable{
		
		static void Main(){
			//take input from user for dispaly table
			Console.Write("Enter the number from 6 to 9");
			int number = Convert.ToInt32(Console.ReadLine());
			
			if(number >=6 && number<=9){  //check number is between 6 and 9
				for(int i = 1; i<11;i++){
					int result = number*i;     //Calculate the number table
					
					//display the result
					Console.WriteLine(number + "*" + i +" = "+result);
				}
			}else{   //display result when number is not in range
					Console.WriteLine("Given number is not in range.");
				}
		}
	}
}