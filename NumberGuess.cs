// Write a program where the user thinks of a number between 1 and 100, and the computer
// tries to guess the number by generating random guesses.
// ● The user provides feedback by indicating whether the guess is high, low, or correct.
// ● The program should be modular, with different functions for generating guesses,
// receiving user feedback, and determining the next guess.

using System;

class NumberGuess{
	
	// Method to play the number guessing game
	public static void NumberGuessGame()
	{
		Random random = new Random();
		int num = random.Next(1, 101); // Generate a random number between 1 and 100
		int guessNum;

		Console.WriteLine("Guess the correct number: ");
		guessNum = Convert.ToInt32(Console.ReadLine());

		// Loop until the correct number is guessed
		while (num != guessNum)
		{
			if (num > guessNum)
			{
				Console.WriteLine("Your guess is smaller than the number. Try again: ");
			}
			else if (num < guessNum)
			{
				Console.WriteLine("Your guess is greater than the number. Try again: ");
			}

			// Read the next guess
			guessNum = Convert.ToInt32(Console.ReadLine());
		}

		// When the correct number is guessed
		Console.WriteLine("Congratulations! The correct number is " + guessNum);
	}

	static void Main()
	{
		// Start the game
		NumberGuessGame();
	}
}
