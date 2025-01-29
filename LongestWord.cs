// Find the Longest Word in a Sentence
// Problem:
// WriteLine a C# program that takes a sentence as input and returns the longest word in the
// sentence.

using System;

class LongestWord {
	 
    static string LargeWord(string str){
        int lastWordCount = 0;
        string result = "";
        int count = 0;
        int lastIndex = 0;

        Console.WriteLine("String length := " + str.Length);

        for(int i = 0; i < str.Length; i++){
            Console.WriteLine("Value of i = " + i);

            if(str[i] == ' '){
               
                if(lastWordCount < count){
                    lastWordCount = count;
                    result  = str.Substring(lastIndex, count);
                } 
                lastIndex = i + 1;
                count = 0;
            } else {
                count++;  // Move count inside the else block to ensure it increments for each character
            }
        }

        //Process the last word after the loop**
        if(lastWordCount < count){
            lastWordCount = count;
            result  = str.Substring(lastIndex, count);
        }

        return result;
    }

    static void Main(){
        Console.WriteLine("Enter the string: ");
        string str = Console.ReadLine();
		
        string result  = LargeWord(str);
        Console.WriteLine("Largest Word: " + result);
    }
}
