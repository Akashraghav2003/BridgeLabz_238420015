//Write a program to check if a number is divisible by 5

using System;

class Divisiblity{

	static void Main(string[] args){
	
		//define a variable name result type string
		string result="";
		
		//take input from user 
		Console.WriteLine("Enter a Number: ");
		int number =Convert.ToInt32(Console.ReadLine());
		
		// check number divisible 5 or not
		if(number%5==0){
			result="Yes";
		}
		else{
			result="No";
		}
		//Display the result
		Console.WriteLine("Is the "+number+" divisible by 5? "+result);
		
		
	}
}