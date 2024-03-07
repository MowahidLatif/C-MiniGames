using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GenerateRandomNumber();
            int userGuess;
            int totalGuesses = 0;

            Console.WriteLine("Welcome to the Number Guessing Game Program!");
            Console.WriteLine("The number is between 0 - 10. Get it within 3 tries.");

            while (totalGuesses < 3)
            {
                Console.Write("Guess your Number: ");
                userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess > number)
                {
                    Console.WriteLine("Try again, your guess was too high.");
                }
                else if (userGuess < number)
                {
                    Console.WriteLine("Try again, your guess was too low.");
                }
                else
                {
                    Console.WriteLine("You Win, Congrats!");
                    return;
                }
                totalGuesses++;
            }

            Console.WriteLine($"Sorry, you've run out of guesses. The number was: {number}");
        }

        static int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(0, 11);
        }
    }
}
