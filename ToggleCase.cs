 // Toggle Case of Characters 
// Problem: 
// Write a C# program to toggle the case of each character in a given string. Convert uppercase letters to lowercase and vice versa.

using System;

class ToggleCase{
	
	static string ChangeCase(string str){
		string result = "";
		for(int i =0; i<str.Length;i++){
			if((int)str[i]>=97 && (int)str[i]<=122){
				int asii = (int)str[i];
                result += (char)(asii - 32); // Convert lowercase to uppercase
			}else if((int)str[i]>=65 && (int)str[i]<=90){
				int asii = (int)str[i];
				result +=  (char)(asii+32);
			}else{
				result += str[i];
			}
			
		}
		return result;
		
	}
	
	static void Main(){
		
		Console.WriteLine("Enter the string: ");
        string str = Console.ReadLine();
		
		string result = ChangeCase(str);
		
		Console.WriteLine("Toggle value of String: "+result);
	}
}