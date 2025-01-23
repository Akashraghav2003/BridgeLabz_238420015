//Write a program to count down the number from the user input value to 1 using a while loop for a rocket launch

using System;

class CountdownForLoop{
	
	static void Main(string[] args){
		
		//take input from user
		Console.Write("Enter the Counter: ");
		int counter=Convert.ToInt32(Console.ReadLine());
		
		for(int i=counter;i>0;i--){
			//Display the counter
			Console.WriteLine(counter);
			counter--; //counter decrement
		}
		
	}
}