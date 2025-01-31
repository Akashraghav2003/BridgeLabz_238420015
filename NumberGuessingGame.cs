


using System;

class NumberGuessingGame{
	
    // Method to get user feedback on the guessed number
	public static char Feedback(int guess){
		Console.WriteLine("Guess number " + guess + " is correct, press 'C'. If it's too low, press 'L'. If it's too high, press 'H'.");
		char feedback = Console.ReadLine()[0];

		// Ensure valid input
		while(feedback != 'H' && feedback != 'L' && feedback != 'C'){
			Console.WriteLine("Invalid input! Only press H, C, or L.");
			feedback = Console.ReadLine()[0];
		}
		return feedback;
	}
	
	// Method to generate a guess within a given range
	public static int GenerateGuess(int low, int last){
		Random random = new Random();
		return random.Next(low, last + 1);
	}

	// Main game logic for guessing the number
	public static void GuessingGame(){
		Console.WriteLine("Think of a number between 1 and 100.");

		int low = 1;
		int last = 100;

		while(true){
			int guess = GenerateGuess(low, last);
			char feedback = Feedback(guess);

			if(feedback == 'C'){
				Console.WriteLine(guess + " is correct!");
				break;
			} else if(feedback == 'H'){
				last = guess - 1; // Adjust upper bound
			} else {
				low = guess + 1; // Adjust lower bound
			}

			// If the range becomes invalid, handle the error
			if (low > last){
				Console.WriteLine("Something went wrong. Please check your responses.");
				break;
			}
		}
	}

	public static void Main(String[] args){
		GuessingGame();
	}
}
