using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); //New Random Object
            string[] words = new string[5] { "Banana", "Apple", "Mango", "Orange", "Kiwi" }; // Array with the words
            int randomIndex = random.Next(words.Length); // Random an index for output the word.
            string randomWord = words[randomIndex]; // getting the word by index 
            string guess = ""; // Empty string to check the while loop.
            int maxGuess = 3; // max user guesses before he lose.
            int guessCount = 0; // a guess count to increment every guessed word and check for the if statement.
            bool IsOutofGuess = false; // a false statement to be used later for checking if lost or won.

            while (guess != randomWord && !IsOutofGuess)
            {
                if (guessCount < maxGuess)
                {
                    Console.Write("Guess the word: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    IsOutofGuess = true;
                }
            }
            if (IsOutofGuess) // lost
            {
                Console.WriteLine("You lose.");
            }
            else // won
            {
                Console.WriteLine("You won.");
            }
            Console.ReadLine();
            

        }
    }
}
