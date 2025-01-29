// Palindrome String Check
// Problem:
// Write a C# program to check if a given string is a palindrome (a string that reads the
// same forward and backward).

using System;

class PalindromeString{
	public static bool CheckPalindrome(string str){
		int i=0; int j = str.Length-1;
		bool isPalindrome = true;
		
		while(i<j){
			if(str[i] != str[j]){
				isPalindrome = false;
				break;
			}
			i++;
			j--;
		}
		return isPalindrome;
	}
	
	public static void Main(){
		
		
		Console.WriteLine("enter the string: ");
		string str = Console.ReadLine();
		
		bool  isPalindrome = CheckPalindrome(str);
		
		if(isPalindrome){
			Console.WriteLine("Given String is  palindrome String ");
		}else{
			Console.WriteLine("Given String is not  palindrome String ");
		}
	}
}