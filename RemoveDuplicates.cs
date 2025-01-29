// Remove Duplicates from a String
// Problem:
// Write a C# program to remove all duplicate characters from a given string and return the
// modified string.


using System;

class RemoveDuplicates{
	
    public static void Main(){
		
        Console.Write("Enter the string: ");
        string str = Console.ReadLine();
        
        string result = "";

        foreach (char c in str){
			string str1 = Char.ToString(c);
            if (!result.Contains(str1)){
				
                result += c;
            }
        }

        Console.WriteLine("String after remove duplicates: " + result);
    }
}
