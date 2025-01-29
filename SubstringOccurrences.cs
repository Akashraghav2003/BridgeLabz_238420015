// 6. Find Substring Occurrences
// Problem:
// Write a C# program to count how many times a given substring occurs in a string.

using System;

class SubstringOccurrences{
	
	static void Main(){
		
        Console.WriteLine("Enter the string: ");
        string str = Console.ReadLine();
		
		
        Console.WriteLine("Enter the substring: ");
        string subStr = Console.ReadLine();
		
		int count = 0;
		int i =0;int j = 0;
		while(i<str.Length-subStr.Length){
			bool match = true;
			while(j<subStr.Length){
				match = true;
				if(str[i+j] != subStr[j]){
					match  = false;
					break;
				}
				j++;

			}if(match){
				count++;
			}
			i++;
			j = 0; 
		}
		
		Console.WriteLine("Total Occurence of SubString In string?: "+ count);
		
	}
}