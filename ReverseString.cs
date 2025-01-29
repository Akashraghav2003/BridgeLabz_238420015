// Reverse a String
// Problem: Write a C# program to reverse a given string without using any built-in reverse functions.


using System;

class ReverseString{
	
	public static string reverse(string str){
		string resultStr = "";
		int n = str.Length;
		
		for(int i= n-1;i>-1; i--){
			resultStr += str[i];
		}
		return resultStr;
	}
	
	static void Main(){
		
		Console.WriteLine("enter the string: ");
		string str = Console.ReadLine();
		
		string resultStr = reverse(str);
		
		Console.WriteLine("the reverse of string: "+ resultStr);
	}
}