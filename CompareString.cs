// Compare Two Strings Using charAt()
// Hint => 
// Take user input using Console.ReadLine().
// Create a method to compare two strings using CharAt() logic (string[index] in C#).
// Compare the result with the built-in string.Equals().



using System;

class CompareString{
	
	public static bool logic (string str1, string str2){
		bool isEqual = true;
		int len1 = str1.Length;
		int len2 = str2.Length;
		
		if(len1 != len2){
			return isEqual = false;
		}else{
			for(int i = 0; i<len1; i++){
				char ch1 = str1[i];
				char ch2 = str2[i];
				
				if(ch1 != ch2){
					isEqual = false;
				}
			}
		}
		return isEqual;
	}
	
	public static void Main(String [] Args){
		Console.WriteLine("Enter the String1: ");
		string str1 = Console.ReadLine();
		
		Console.WriteLine("Enter the String2: ");
		string str2 = Console.ReadLine();
		
		bool isEqual = true;
		
		if(str1.Equals(str2)){
			isEqual = true;
		}
		
		if(logic(str1, str2) == isEqual){
			Console.WriteLine("String are equal.");
		}else{
			Console.WriteLine("String is not equal.");
		}
	}
}