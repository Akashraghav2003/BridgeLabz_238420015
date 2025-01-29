// Create a Substring Using charAt()
      // Hint => 
// Take user input using Console.ReadLine() for string, start index, and end index.
// Write a method to create a substring using charAt() (string[index] in C#).
// Use string.Substring() to generate the substring and compare the results.

using System;

class SubString{
	
	public static string CreateSubString(string str1, int startIndex, int endIndex){
		string subString ="";
		
		while(startIndex < endIndex ){
			subString += str1[startIndex++];
		}
		
		return subString;
	}
	
	public static void Main(String [] Args){
		Console.WriteLine("Enter the String1: ");
		string str1 = Console.ReadLine();
		
		Console.WriteLine("Enter the Start index: ");
		int startIndex =Convert.ToInt32(Console.ReadLine()) ;
		
		Console.WriteLine("Enter the end index: ");
		int endIndex =Convert.ToInt32(Console.ReadLine()) ;
		
		string subString = str1.Substring(startIndex,endIndex-startIndex);

		
		if(CreateSubString(str1, startIndex, endIndex) == subString){
			Console.WriteLine(subString);
		}else{
			Console.WriteLine("subString is not equal.");
		}
	}
}