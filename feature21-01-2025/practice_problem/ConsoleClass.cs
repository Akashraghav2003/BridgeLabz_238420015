using System;
namespace Project{
class ConsoleClass
{
    static void Main(string[] args)
    {
        // Write function is used to give the output in a single line, not moved to the next line.
        Console.Write("Hii this side is Akash Raghav.");
        // WriteLine function is used to give the output to the console and terminate the present line.
        Console.WriteLine(" Having the great aim.");
        // Read function is used to read a single character from the input and it returns the ASCII value.
        int asciiValue = Console.Read();
        char ans1 = (char)asciiValue; // Cast ASCII value to char
        // ReadLine is a function used to read all string from the user.
        string ans2 = Console.ReadLine();

        Console.WriteLine("The ASCII value of given input is: " + asciiValue);
        Console.Write("Given input is: " + ans2);

        // ReadKey is used to make the program wait and it waits to press a key and takes input.
        Console.ReadKey();
    }
}
}