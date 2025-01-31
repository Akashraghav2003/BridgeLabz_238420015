// 5. Palindrome Checker:
// Write a program that checks if a given string is a palindrome (a word, phrase, or sequence
// that reads the same backward as forward).
// ● Break the program into functions for input, checking the palindrome condition, and
// displaying the result.
using System;

class PalindromeChecker{
	
	// Method to take string input from the user
	public static string Input(){
		Console.WriteLine("Enter the string: ");
		return Console.ReadLine();
	}

	// Method to check if the given string is a palindrome
	public static bool CheckPalindrome(){
		string str = Input();
		int i = 0, j = str.Length - 1;
		bool isPalindrome = true;

		// Compare characters from both ends moving toward the center
		while(i < j){
			if(str[i] != str[j]){
				isPalindrome = false;
				break;
			}
			i++;
			j--;
		}
		return isPalindrome;
	}

	// Display the result
	static void Display(){
		if(CheckPalindrome()){
			Console.WriteLine("Given string is a palindrome.");
		}else{
			Console.WriteLine("Given string is not a palindrome.");
		}
	}

	public static void Main(){
		Display();
	}
}
