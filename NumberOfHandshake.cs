// Create a program to find the maximum number of handshakes among N number of students.

using System;

namespace Assignment4 {
    
    // Class to calculate the number of handshakes
    class NumberOfHandshake {
        
        // Method to calculate and display the total number of handshakes
        public void Handshake(int person) {
            int combination = (person * (person - 1)) / 2;
            Console.WriteLine("Total no of handshakes: " + combination);
        }
        
        // Main method 
        static void Main(String[] args) {
			
			//to get the number of persons and call the Handshake method
            Console.Write("Enter the no of persons: ");
            int person = Convert.ToInt32(Console.ReadLine());
            
			//call the Handshake method
            NumberOfHandshake noh = new NumberOfHandshake();
            noh.Handshake(person);
        }
    }
}
