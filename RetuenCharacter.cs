// Return All Characters Without Using ToCharArray()
// Hint => 
// Write a method to return characters of a string without using ToCharArray() (loop through string[index]).
// Compare the result with the built-in ToCharArray() method.

using System;

class ReturnCharacter{
	public static char [] CharacterArray(string str1){
		int n = str1.Length;
		char [] result = new char [n];
		
		for(int i = 0; i<n; i++){
			result[i] = str1[i];
		}
		
		
		return result;
	}
	
	static void Main(String [] args){
		Console.WriteLine("Enter the String: ");
		string str1 = Console.ReadLine();
		
		char [] result = str1.ToCharArray();
		
		char [] characterArray = CharacterArray(str1);
		bool isEqual = true;
		
		if(result.Length != characterArray.Length){
			isEqual = false;
		}else{
			for(int i =0; i<result.Length; i++){
				if(result[i] != characterArray[i]){
					isEqual = false;
					break;
				}
			}
		}
		
		if(isEqual){
			for(int i = 0; i<result.Length;i++){
				Console.WriteLine(result[i]);
				
			}
		}else{
			Console.WriteLine("Both Array Is not equal");
		}
		
	}
}
